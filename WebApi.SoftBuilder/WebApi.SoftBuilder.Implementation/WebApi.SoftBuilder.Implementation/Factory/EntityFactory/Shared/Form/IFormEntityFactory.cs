using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    public interface IFormEntityFactory : IEntityFactory<IFormEntity>
    {
        IFormEntity GetFieldEntity();

        IFormEntity GetFormEntity();

        IFormEntity GetFormMetaEntity();
    }
}
