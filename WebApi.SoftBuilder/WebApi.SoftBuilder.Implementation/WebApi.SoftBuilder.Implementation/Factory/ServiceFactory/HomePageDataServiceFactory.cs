using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Factory.ServiceFactory
{
    public class HomePageDataServiceFactory<T, U> : IHomePageDataServiceFactory<T, U> where T : IHomePageDataService<U>, new() where U : HomeEntity
    {
        public T GetService()
        {
            return new T();
        }
    }
}
