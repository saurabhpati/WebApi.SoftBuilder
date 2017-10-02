using System;
using System.Web.Http;
using WebApi.SoftBuilder.Implementation.Factory.ServiceFactory;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Models.Home;
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

        private IHomePageDataService<AboutModel> aboutSectionDataService;
        private IHomePageDataService<ContactModel> contactSectionDataService;
        private IHomePageDataServiceFactory<AboutSectionDataService<AboutModel>, AboutModel> aboutSectionDataServiceFactory;
        private IHomePageDataServiceFactory<ContactSectionDataService<ContactModel>, ContactModel> contactSectionDataServiceFactory;


        #endregion

        #region Constructor

        /// <summary>
        /// The constructor to initialize the HomeController class
        /// </summary>
        public HomeController()
        {
            this.aboutSectionDataServiceFactory = new HomePageDataServiceFactory<AboutSectionDataService<AboutModel>, AboutModel>();
            this.contactSectionDataServiceFactory = new HomePageDataServiceFactory<ContactSectionDataService<ContactModel>, ContactModel>();
            this.aboutSectionDataService = this.aboutSectionDataServiceFactory.GetService();
            this.contactSectionDataService = this.contactSectionDataServiceFactory.GetService();

            if (this.aboutSectionDataService == null)
            {
                throw new NullReferenceException(nameof(this.aboutSectionDataService));
            }

            if (this.contactSectionDataService == null)
            {
                throw new NullReferenceException(nameof(this.contactSectionDataService));
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
        public AboutModel About()
        {
            return this.aboutSectionDataService.GetSectionData();
        }

        /// <summary>
        /// The Http Get action to get the contact data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted contact model</returns>
        [HttpGet]
        [Route("contact")]
        public ContactModel Contact()
        {
            return this.contactSectionDataService.GetSectionData();
        }

        #endregion
    }
}
