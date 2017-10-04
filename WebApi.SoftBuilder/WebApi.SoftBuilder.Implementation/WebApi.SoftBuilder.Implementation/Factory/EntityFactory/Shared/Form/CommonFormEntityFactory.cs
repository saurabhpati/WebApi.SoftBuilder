using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    public class CommonFormEntityFactory<T> : IFormEntityFactory<T> where T : IFormEntity, new()
    {
        public virtual T GetEntity()
        {
            return new T();
        }
    }
}
