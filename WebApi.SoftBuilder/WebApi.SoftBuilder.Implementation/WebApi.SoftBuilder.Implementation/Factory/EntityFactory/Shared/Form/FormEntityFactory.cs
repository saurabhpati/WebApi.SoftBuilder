using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    public class FormEntityFactory : IFormEntityFactory
    {
        public IFormEntity GetFieldEntity()
        {
            return new FieldEntity();
        }

        public IFormEntity GetFormEntity()
        {
            return new FormEntity();
        }

        public IFormEntity GetFormMetaEntity()
        {
            return new FormMetaEntity();
        }
    }
}
