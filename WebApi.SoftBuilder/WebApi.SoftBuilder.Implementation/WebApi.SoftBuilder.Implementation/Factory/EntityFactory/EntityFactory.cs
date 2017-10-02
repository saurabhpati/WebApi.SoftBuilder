using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    public class EntityFactory<T> : IEntityFactory<T> where T : ClientModelBase, new()
    {
        public virtual T GetEntity()
        {
            return new T();
        }
    }
}
