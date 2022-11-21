using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Crawling;
using CluedIn.Core.Data.Relational;
using CluedIn.Core.Net.Mail;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using CluedIn.Providers.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CluedIn.Provider.CommonDataModel
{
    public class CommonDataModelProvider : IProvider, IProviderMetadata, IExtendedProviderMetadata
    {
        public CommonDataModelProvider()
        {
        }

        private static IProviderMetadata _providerMetadata;
        private static IProviderMetadata Metadata
        {
            get
            {
                return _providerMetadata ??= new ProviderMetadata
                {
                    Id = Guid.Parse("884D9CCE-77A7-4372-A65E-822C52E58AD4"),
                    ComponentName = "CommonDataModel",
                    Name = "Common Data Model",
                    Type = IntegrationType.DataSource.ToString(),
                    SupportsConfiguration = false,
                    SupportsWebHooks = false,
                    SupportsAutomaticWebhookCreation = false,
                    RequiresAppInstall = false,
                    AppInstallUrl = null,
                    ReAuthEndpoint = null,
                    ComponentEmailDetails = null,
                };
            }
        }

        public IProviderInfo Definition => throw new NotImplementedException();

        public IEnumerable<IEntityActionBuilder> EntityActionBuilders => throw new NotImplementedException();

        public bool ScheduleCrawlJobs => false;

        public string Name => Metadata.Name;

        public string Type => Metadata.Type;

        public bool SupportsWebHooks => Metadata.SupportsWebHooks;

        public bool RequiresAppInstall => Metadata.RequiresAppInstall;

        public string AppInstallUrl => Metadata.AppInstallUrl;

        public bool SupportsConfiguration => Metadata.SupportsConfiguration;

        public bool SupportsAutomaticWebhookCreation => Metadata.SupportsAutomaticWebhookCreation;

        public string ReAuthEndpoint => Metadata.ReAuthEndpoint;

        public string ComponentName => Metadata.ComponentName;

        public ComponentEmailDetails ComponentEmailDetails => Metadata.ComponentEmailDetails;

        public IEnumerable<string> AuthTypes => Metadata.AuthTypes;

        public Guid Id => Metadata.Id;

        public string Icon => "Resources.cluedin.png";

        public string Domain => "";

        public string About => "Common Data Model";

        public AuthMethods AuthMethods => null;

        public IEnumerable<Control> Properties => new Control[] { };

        public Guide Guide => new Guide();

        IntegrationType IExtendedProviderMetadata.Type => IntegrationType.DataSource;

        public Task<IEnumerable<WebHookSignature>> CreateWebHook(ExecutionContext context, CrawlJobData jobData, IWebhookDefinition webhookDefinition, IDictionary<string, object> config)
        {
            throw new NotImplementedException();
        }

        public Task DeleteWebHook(ExecutionContext context, CrawlJobData jobData, IWebhookDefinition webhookDefinition)
        {
            throw new NotImplementedException();
        }

        public Task<ExpectedStatistics> FetchUnSyncedEntityStatistics(ExecutionContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public Task<AccountInformation> GetAccountInformation(ExecutionContext context, CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public Task<CrawlJobData> GetCrawlJobData(ProviderUpdateContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public Task<IDictionary<string, object>> GetHelperConfiguration(ProviderUpdateContext context, CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public Task<IDictionary<string, object>> GetHelperConfiguration(ProviderUpdateContext context, CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId, string folderId)
        {
            throw new NotImplementedException();
        }

        public ProcessingRestriction GetJobProcessingRestriction(CrawlJobData jobData)
        {
            throw new NotImplementedException();
        }

        public Task<CrawlLimit> GetRemainingApiAllowance(ExecutionContext context, CrawlJobData jobData, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WebhookDefinition>> GetWebHooks(ExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public string Schedule(DateTimeOffset relativeDateTime, bool webHooksEnabled)
        {
            throw new NotImplementedException();
        }

        public Task<bool> TestAuthentication(ProviderUpdateContext context, IDictionary<string, object> configuration, Guid organizationId, Guid userId, Guid providerDefinitionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> WebhookManagementEndpoints(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }
    }
}
