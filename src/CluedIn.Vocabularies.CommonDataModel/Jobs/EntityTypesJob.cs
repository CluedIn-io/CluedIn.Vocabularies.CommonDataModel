using CluedIn.Core;
using CluedIn.Core.Data.Relational;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CluedIn.DataStore.Document.Queries;
using System.Reflection;
using System.Threading;

namespace CluedIn.Vocabularies.CommonDataModel.Jobs
{
    public class EntityTypesJob : ICdmJob
    {
        private readonly ApplicationContext appContext;
        private readonly ILogger logger;
        private bool hasBeenExecuted = false;

        public EntityTypesJob(ApplicationContext appContext, ILogger<EntityTypesJob> logger)
        {
            this.appContext = appContext;
            this.logger = logger;
        }

        public async Task Run(CancellationTokenSource cancellationTokenSource)
        {
            logger.LogDebug($"[CommonDataModel] Start Job : {nameof(EntityTypesJob)}");

            if (hasBeenExecuted)
            {
                cancellationTokenSource.Cancel();
            }
            else
            {
                var organizations = await GetOrganizations();

                if (!organizations.Any())
                    logger.LogWarning($"[CommonDataModel] No Organization found!");

                foreach (var organization in organizations)
                {
                    using var context = appContext.CreateExecutionContext(organization.Id);
                    var dataStore = context.Organization.DataStores.GetDataStore<EntityType>();

                    var entityTypes = await GetEntityTypes(context);

                    //entityTypes became empty after this line
                    logger.LogDebug($"[CommonDataModel] EntityTypes: {entityTypes.Count()}.");
                    
                    var constValues = GetConstants(typeof(CommonDataModelEntityTypes));

                    List<Guid> newGuids = new List<Guid>();
                    var newEntityTypes = constValues
                        .Where(w => !entityTypes.Any(a => a.Type.Equals(w)))
                        .Select(entityTypeName => new EntityType
                        {
                            Id = GenerateGuid(entityTypes, newGuids),
                            Active = true,
                            DisplayName = entityTypeName.Replace("/", "").SplitCamelCase(),
                            Icon = null,
                            LayoutConfiguration = null,
                            Route = null,
                            Type = entityTypeName
                        }).ToList();

                    logger.LogDebug($"[CommonDataModel] {newEntityTypes.Count()} New Entity Types will be created!");

                    while (newEntityTypes.Count() > 0)
                    {
                        var batchEntityTypes = newEntityTypes.Take(10);

                        await dataStore.InsertAsync(context, batchEntityTypes);

                        newEntityTypes.RemoveAll(r => batchEntityTypes.Any(a => a.Type == r.Type));
                    }

                    logger.LogDebug($"[CommonDataModel] AlL new Entity Types has been successfully created!");

                    hasBeenExecuted = true;
                    cancellationTokenSource.Cancel();
                    break;
                }
            }
            logger.LogDebug($"[CommonDataModel] Finish Job : {nameof(EntityTypesJob)}");
        }
        private Guid GenerateGuid(IEnumerable<EntityType> entityTypes, List<Guid> newGuids)
        {
            Guid guid = Guid.NewGuid();

            while (entityTypes.Any(a => a.Id == guid) || newGuids.Any(a => a == guid))
                guid = Guid.NewGuid();

            newGuids.Add(guid);

            return guid;
        }

        private async Task<IEnumerable<EntityType>> GetEntityTypes(Core.ExecutionContext context)
        {
            var dataStore = context.Organization.DataStores.GetDataStore<EntityType>();

            var result = await dataStore.SelectAsync(context, n => n.Active).ToList();
            // TODO - GetEntityTypes can return null
            try
            {
                var types = EntityQueries.GetEntityTypes(context).Select(n => n.Term).ToList();
                if (types.Count() > 0)
                    result = result.Union(types.Select(n => new EntityType { Type = n })).ToList();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"[CommonDataModel] EntityQueries.GetEntityTypes throw an error!");
            }
            result = result.DistinctBy(n => n.Type).ToList();
            
            logger.LogDebug($"[CommonDataModel] EntityTypes Identified: {result.Count()}");

            return result;
        }

        private async Task<IEnumerable<OrganizationProfile>> GetOrganizations()
        {
            var organizationProfileStore = appContext.System.Organization.DataStores.GetDataStore<OrganizationProfile>();
            var organizations =
                await organizationProfileStore.SelectAsync(appContext.System.CreateExecutionContext(),
                    o => o.Name != null);
            return organizations;
        }
        
        private List<string> GetConstants(Type type)
        {
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public |
                 BindingFlags.Static | BindingFlags.FlattenHierarchy);

            return fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly)
                .Select(x => (string)x.GetRawConstantValue())
                .ToList();
        }
    }
}
