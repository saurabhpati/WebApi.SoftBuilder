using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Service
{
    /// <summary>
    /// Contract for home page data service.
    /// </summary>
    public interface IHomePageDataService : IPageDataService
    {
        /// <summary>
        /// Gets the about data for the about section for the home page.
        /// </summary>
        /// <returns>The about data model.</returns>
        IClientModel GetAboutData();

        /// <summary>
        /// Gets the contact data for the contact section for the home page.
        /// </summary>
        /// <returns>The contact data model.</returns>
        IClientModel GetContactData();
    }
}
