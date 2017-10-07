using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form
{
    /// <summary>
    /// The contract that a factory has to implement to be an entity factory for all entities related to contents or data of a form.
    /// </summary>
    public interface IFormEntityFactory : IEntityFactory<IFormEntity>
    {
        /// <summary>
        /// Gets the manufactured field entity in the form of IFormEntity.
        /// </summary>
        /// <returns>The field entity.</returns>
        IFormEntity GetFieldEntity();

        /// <summary>
        /// Gets the manufactured form entity in the form of IFormEntity.
        /// </summary>
        /// <returns>The form entity.</returns>
        IFormEntity GetFormEntity();

        /// <summary>
        /// Gets the manufactured form meta entity in the form of IFormEntity.
        /// </summary>
        /// <returns>The form meta entity.</returns>
        IFormEntity GetFormMetaEntity();
    }
}
