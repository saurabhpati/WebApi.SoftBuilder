using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Shared.Factory.ServiceFactory
{
    public interface IPageDataServiceFactory<T, U> where T : IPageDataService<U> where U : IClientModel
    {
    }
}
