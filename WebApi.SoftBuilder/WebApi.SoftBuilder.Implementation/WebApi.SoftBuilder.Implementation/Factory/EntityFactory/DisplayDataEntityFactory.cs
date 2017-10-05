using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    public class DisplayDataEntityFactory : EntityFactory
    {
        public override ClientModelBase GetEntity()
        {
            return new DisplayDataEntity();
        }
    }
}
