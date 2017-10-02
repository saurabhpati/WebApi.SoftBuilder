using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Service
{
    /// <summary>
    /// Contract for home page data service.
    /// </summary>
    public interface IHomePageDataService<T> : IPageDataService<T> where T : IClientModel
    {
        T GetSectionData();
    }
}
