using System.Web.Http;
using WebApi.SoftBuilder.Models.Home;

namespace WebApi.SoftBuilder.Controllers
{
    /// <summary>
    /// Home Api Controller to get data for the home page of the application.
    /// </summary>
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        /// <summary>
        /// The Http Get action to get the about data from the service for the home page.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("about")]
        public AboutModel About()
        {
            HomePageDataService dataService = new HomePageDataService();
            return dataService.GetAboutData();
        }
    }
}
