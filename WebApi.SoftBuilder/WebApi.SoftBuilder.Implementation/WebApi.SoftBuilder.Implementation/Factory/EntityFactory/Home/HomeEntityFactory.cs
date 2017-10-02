using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    public class HomeEntityFactory<T> : IEntityFactory<T> where T : ClientModelBase, new()
    {
        public virtual T GetEntity()
        {
            return new T();
        }
    }
}
