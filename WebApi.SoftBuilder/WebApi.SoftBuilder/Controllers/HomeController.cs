using System.Web.Http;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Models.Home;
using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Controllers
{
    /// <summary>
    /// Home Api Controller to get data for the home page of the application.
    /// </summary>
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        #region Private Fields

        private IHomePageDataService dataService;

        #endregion

        #region Constructor

        /// <summary>
        /// The constructor to initialize the HomeController class
        /// </summary>
        public HomeController()
        {
            this.dataService = new HomePageDataService();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Http Get action to get the about data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted about model</returns>
        [HttpGet]
        [Route("about")]
        public IClientModel About()
        {
            return this.dataService.GetAboutData();
        }

        /// <summary>
        /// The Http Get action to get the contact data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted contact model</returns>
        [HttpGet]
        [Route("contact")]
        public IClientModel Contact()
        {
            return this.dataService.GetContactData();
        }

        #endregion
    }
}
