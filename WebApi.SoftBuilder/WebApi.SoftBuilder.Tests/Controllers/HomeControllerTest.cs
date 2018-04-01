using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.SoftBuilder.Controllers;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form;
using WebApi.SoftBuilder.Implementation.Factory.ServiceFactory;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private static IHomePageDataService<HomeEntity> homePageDataService;
        private static IEntityFactory<DisplayDataEntity> displayDataEntityFactory;
        private static IHomeEntityFactory homeEntityFactory;
        private static IFormEntityFactory formEntityFactory;
        private static IHomePageDataServiceFactory<HomePageDataService, HomeEntity> homePageDataServiceFactory;
        private static HomeController homeController;

        [ClassInitialize]
        public static void InitHomeControllerTest(TestContext testContext)
        {
            formEntityFactory = new FormEntityFactory();
            homeEntityFactory = new HomeEntityFactory();
            displayDataEntityFactory = new DisplayDataEntityFactory();
            homePageDataServiceFactory = new HomePageDataServiceFactory(displayDataEntityFactory, homeEntityFactory, formEntityFactory);
            homePageDataService = new HomePageDataService(displayDataEntityFactory, homeEntityFactory, formEntityFactory);
            homeController = new HomeController(homePageDataServiceFactory);
        }

        [TestMethod]
        public void AboutTest()
        {
            AboutEntity entity = homeController.About();

            Assert.IsNotNull(entity);
            Assert.IsNotNull(entity.Id);
            Assert.IsNotNull(entity.Name);
            Assert.IsNotNull(entity.DisplayDataList);
            Assert.Equals(entity.Id, "about");
            Assert.Equals(entity.Name, "About");
            Assert.Equals(entity.DisplayDataList.Count, 2);
        }
    }
}
