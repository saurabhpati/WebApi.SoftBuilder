using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Service
{
    /// <summary>
    /// The contract that a service has to implement to be a service for all entities related to any entity or content in the home page.
    /// </summary>
    /// <typeparam name="T">The entity, model or content related to any page of the application.</typeparam>
    public interface IPageDataService<T> where T : IClientModel
    {
    }
}
