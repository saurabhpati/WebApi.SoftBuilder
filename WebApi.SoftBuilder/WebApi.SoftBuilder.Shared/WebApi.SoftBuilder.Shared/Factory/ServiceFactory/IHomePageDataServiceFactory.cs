using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Shared.Factory.ServiceFactory
{
    /// <summary>
    /// The contract that a factory has to implement to be a service factory for all entities related to any entity or content in the home page.
    /// </summary>
    /// <typeparam name="T">The service that gets data related to the home page.</typeparam>
    /// <typeparam name="U">The entity, model or content related to the home page.</typeparam>
    public interface IHomePageDataServiceFactory<T, U> : IPageDataServiceFactory<T, U> where T : IHomePageDataService<U> where U : HomeEntity
    {
        /// <summary>
        /// Gets the service that is supposed to get the related to the home page.
        /// </summary>
        /// <returns>The service of type IHomePageDataService.</returns>
        T GetService();
    }
}
