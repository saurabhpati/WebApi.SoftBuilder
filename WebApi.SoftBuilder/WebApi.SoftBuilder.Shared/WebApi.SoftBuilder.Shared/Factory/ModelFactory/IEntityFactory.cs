using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Factory.ModelFactory
{
    public interface IEntityFactory<T> where T : IClientModel
    {
        T GetEntity();
    }
}
