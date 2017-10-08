using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Factory.ServiceFactory
{
    /// <summary>
    /// The factory to initialize the service that give model or entity content or sections of the home page.
    /// </summary>
    public class HomePageDataServiceFactory : IHomePageDataServiceFactory<HomePageDataService, HomeEntity>
    {
        private IEntityFactory<DisplayDataEntity> displayDataEntityFactory;
        private IHomeEntityFactory homeEntityFactory;
        private IFormEntityFactory formEntityFactory;

        public HomePageDataServiceFactory(
            IEntityFactory<DisplayDataEntity> displayDataEntityFactory,
            IHomeEntityFactory homeEntityFactory,
            IFormEntityFactory formEntityFactory)
        {
            this.displayDataEntityFactory = displayDataEntityFactory;
            this.homeEntityFactory = homeEntityFactory;
            this.formEntityFactory = formEntityFactory;
        }

        /// <summary>
        /// Gets the manufactured instance of the service that will return the type of entity or content that the service was subscribed with.
        /// </summary>
        /// <returns>The service instance conforming to IHomePageDataService.</returns>
        public HomePageDataService GetService()
        {
            return new HomePageDataService(this.displayDataEntityFactory, this.homeEntityFactory, this.formEntityFactory);
        }
    }
}
