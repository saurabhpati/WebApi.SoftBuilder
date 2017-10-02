using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Service
{
    public abstract class HomePageDataServiceBase<T> : IHomePageDataService<T> where T : ClientModelBase
    {
        public abstract T GetSectionData();
    }
}
