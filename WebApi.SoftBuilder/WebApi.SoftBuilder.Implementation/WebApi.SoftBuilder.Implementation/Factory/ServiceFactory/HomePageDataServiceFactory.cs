using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Implementation.Service;
using WebApi.SoftBuilder.Shared.Factory.ServiceFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.ServiceFactory
{
    public class HomePageDataServiceFactory<T, U> : IHomePageDataServiceFactory<T, U> where T : HomePageDataServiceBase<U>, new() where U : ClientModelBase
    {
    }
}
