using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    public abstract class EntityFactory : IEntityFactory<ClientModelBase>
    {
        public abstract ClientModelBase GetEntity();
    }
}
