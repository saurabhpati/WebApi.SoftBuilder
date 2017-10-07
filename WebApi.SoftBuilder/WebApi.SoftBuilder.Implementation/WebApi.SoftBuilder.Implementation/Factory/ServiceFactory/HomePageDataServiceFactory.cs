using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Factory.ServiceFactory
{
    /// <summary>
    /// The factory to initialize the service that give model or entity content or sections of the home page.
    /// </summary>
    /// <typeparam name="T">The type of service required for a particular entity for the particular section on the home page.</typeparam>
    /// <typeparam name="U">The type of entity or model conforming to HomeEntity for a particular section on the home page.</typeparam>
    public class HomePageDataServiceFactory<T, U> : IHomePageDataServiceFactory<T, U> where T : IHomePageDataService<U>, new() where U : HomeEntity
    {
        /// <summary>
        /// Gets the manufactured instance of the service that will return the type of entity or content that the service was subscribed with.
        /// </summary>
        /// <returns>The service instance conforming to IHomePageDataService.</returns>
        public T GetService()
        {
            return new T();
        }
    }
}
