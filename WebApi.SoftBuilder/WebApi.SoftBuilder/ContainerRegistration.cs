using Microsoft.Practices.Unity;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form;
using WebApi.SoftBuilder.Implementation.Factory.ServiceFactory;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder
{
    /// <summary>
    /// Registration of Dependencies for the current assembly
    /// </summary>
    public class ContainerRegistration
    {
        /// <summary>
        /// Registers dependencies for the current assembly for the application.
        /// </summary>
        /// <param name="container">The unity container object</param>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IHomePageDataServiceFactory<HomePageDataService, HomeEntity>, HomePageDataServiceFactory>(
                new InjectionConstructor(
                    typeof(IEntityFactory<DisplayDataEntity>),
                    typeof(IHomeEntityFactory),
                    typeof(IFormEntityFactory)
                    )
            );
        }
    }
}