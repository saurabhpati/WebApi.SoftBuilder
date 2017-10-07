using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Shared.Factory.ServiceFactory
{
    /// <summary>
    /// The contract that a factory has to implement to be a service factory for all entities related to any entity or content in the application.
    /// </summary>
    /// <typeparam name="T">The service that gets data related to any page of the applicationsss.</typeparam>
    /// <typeparam name="U">The entity, model or content related to any page of the application.</typeparam>
    public interface IPageDataServiceFactory<T, U> where T : IPageDataService<U> where U : IClientModel
    {
    }
}
