using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CluedIn.Vocabularies.CommonDataModel.Jobs;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CommonDataModelInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ICdmJob>()
                .ImplementedBy(typeof(EntityTypesJob))
                .LifestyleTransient());
        }
    }
}
