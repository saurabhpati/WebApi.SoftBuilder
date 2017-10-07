using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Service
{
    /// <summary>
    /// The contract that a service has to implement to be a service for all entities related to any entity or content in the home page.
    /// </summary>
    /// <typeparam name="T">The entity, model or content related to the home page.</typeparam>
    public interface IHomePageDataService<T> : IPageDataService<T> where T : IClientModel
    {
        /// <summary>
        /// Gets the data related to the about section of the home page.
        /// </summary>
        /// <returns>The home page entity containing the about data.</returns>
        T GetAboutSectionData();

        /// <summary>
        /// Gets the data related to the contact section of the home page.
        /// </summary>
        /// <returns>The home page entity containing the contact data.</returns>
        T GetContactSectionData();
    }
}
