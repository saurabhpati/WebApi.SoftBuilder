using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    public interface IFormEntityFactory<T> : IEntityFactory<T> where T : IFormEntity
    {
        T GetFieldEntity();

        T GetMetaEntity();
    }
}
