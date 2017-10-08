using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    /// <summary>
    /// The entity factory to manufacture the form entity or its related form content entity.
    /// </summary>
    public class FormEntityFactory : IFormEntityFactory
    {
        public IFormEntity GetEntity()
        {
            return new FormEntity();
        }

        /// <summary>
        /// Gets the manufactured field entity.
        /// </summary>
        /// <returns>The field entity.</returns>
        public IFormEntity GetFieldEntity()
        {
            return new FieldEntity();
        }

        /// <summary>
        /// Gets the manufactured form entity.
        /// </summary>
        /// <returns>The form entity.</returns>
        public IFormEntity GetFormEntity()
        {
            return new FormEntity();
        }

        /// <summary>
        /// Gets the manufactured form meta entity.
        /// </summary>
        /// <returns>The form meta entity.</returns>
        public IFormEntity GetFormMetaEntity()
        {
            return new FormMetaEntity();
        }
    }
}
