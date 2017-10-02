using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Shared.Factory.ServiceFactory
{
    public interface IHomePageDataServiceFactory<T, U> : IPageDataServiceFactory<T, U> where T : IHomePageDataService<U> where U : IClientModel
    {
        T GetService();
    }
}
