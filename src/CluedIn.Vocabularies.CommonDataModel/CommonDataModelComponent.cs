using CluedIn.Core;
using CluedIn.Core.Server;
using CluedIn.Vocabularies.CommonDataModel.Jobs;
using ComponentHost;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CluedIn.Vocabularies.CommonDataModel
{
    [Component("Common Data Model", ComponentType.Service, Components.Server, InitializeOrder = ComponentInitializeOrder.Last, Isolation = ComponentIsolation.NotIsolated)]
    public class CommonDataModelComponent : ServiceApplicationComponent<IServer>
    {
        public CommonDataModelComponent(ComponentInfo componentInfo) : base(componentInfo)
        {
        }

        public override void Start()
        {
            try
            {
                Log.LogInformation("[CommonDataModel] Initializing");

                Container.Install(new CommonDataModelInstaller());
                State = ServiceState.Started;

                var entityTypeJob = Container.Resolve<ICdmJob>(); 
                var cancellationTokenSource = new CancellationTokenSource();
                Task.Run(async () =>
                {
                    while (!cancellationTokenSource.IsCancellationRequested)
                    {
                        try
                        {
                            await entityTypeJob.Run(cancellationTokenSource);
                        }
                        catch (Exception ex)
                        {
                            Log.LogError(ex, $"[CommonDataModel] Job {entityTypeJob.GetType()}");
                        }

                        await Task.Delay(TimeSpan.FromSeconds(30), cancellationTokenSource.Token);
                    }
                }, cancellationTokenSource.Token);
            }
            catch (Exception ex)
            {
                Log.LogError(ex, "[CommonDataModel] An error occurred in starting the component");
            }
        }

        public override void Stop()
        {
            if (State == ServiceState.Stopped)
                return;

            State = ServiceState.Stopped;
        }
    }
}
