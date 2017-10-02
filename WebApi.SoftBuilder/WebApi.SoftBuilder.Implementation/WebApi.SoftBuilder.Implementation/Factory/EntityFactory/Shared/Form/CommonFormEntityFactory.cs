using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    public class CommonFormEntityFactory<T> : IFormEntityFactory<T> where T : IFormEntity, new()
    {
        public virtual T GetEntity()
        {
            return new T();
        }

        public virtual T GetFieldEntity()
        {
            return new T();
        }

        public virtual T GetMetaEntity()
        {
            return new T();
        }
    }
}
