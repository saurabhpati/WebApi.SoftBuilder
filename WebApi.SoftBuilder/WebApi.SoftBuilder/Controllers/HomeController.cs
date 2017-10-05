using System;
using System.Web.Http;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Factory.ServiceFactory;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
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

        private IHomePageDataService<HomeEntity> homePageDataService;
        private IHomePageDataServiceFactory<HomePageDataService, HomeEntity> homePageDataServiceFactory;

        #endregion

        #region Constructor

        /// <summary>
        /// The constructor to initialize the HomeController class
        /// </summary>
        public HomeController()
        {
            this.homePageDataServiceFactory = new HomePageDataServiceFactory<HomePageDataService, HomeEntity>();
            this.homePageDataService = this.homePageDataServiceFactory.GetService();

            if (this.homePageDataService == null)
            {
                throw new NullReferenceException(nameof(this.homePageDataService));
            }

            if (this.homePageDataService == null)
            {
                throw new NullReferenceException(nameof(this.homePageDataService));
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Http Get action to get the about data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted about model</returns>
        [HttpGet]
        [Route("about")]
        public AboutEntity About()
        {
            return this.homePageDataService.GetAboutSectionData() as AboutEntity;
        }

        /// <summary>
        /// The Http Get action to get the contact data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted contact model</returns>
        [HttpGet]
        [Route("contact")]
        public ContactEntity Contact()
        {
            return this.homePageDataService.GetContactSectionData() as ContactEntity;
        }

        #endregion
    }
}
