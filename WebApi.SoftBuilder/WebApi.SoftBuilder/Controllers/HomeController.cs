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

        private IHomePageDataService<AboutEntity> aboutSectionDataService;
        private IHomePageDataService<ContactEntity> contactSectionDataService;
        private IHomePageDataServiceFactory<AboutSectionDataService<AboutEntity>, AboutEntity> aboutSectionDataServiceFactory;
        private IHomePageDataServiceFactory<ContactSectionDataService<ContactEntity>, ContactEntity> contactSectionDataServiceFactory;


        #endregion

        #region Constructor

        /// <summary>
        /// The constructor to initialize the HomeController class
        /// </summary>
        public HomeController()
        {
            this.aboutSectionDataServiceFactory = new HomePageDataServiceFactory<AboutSectionDataService<AboutEntity>, AboutEntity>();
            this.contactSectionDataServiceFactory = new HomePageDataServiceFactory<ContactSectionDataService<ContactEntity>, ContactEntity>();
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
        public AboutEntity About()
        {
            return this.aboutSectionDataService.GetSectionData();
        }

        /// <summary>
        /// The Http Get action to get the contact data from the service for the home page.
        /// </summary>
        /// <returns>The Json converted contact model</returns>
        [HttpGet]
        [Route("contact")]
        public ContactEntity Contact()
        {
            return this.contactSectionDataService.GetSectionData();
        }

        #endregion
    }
}
