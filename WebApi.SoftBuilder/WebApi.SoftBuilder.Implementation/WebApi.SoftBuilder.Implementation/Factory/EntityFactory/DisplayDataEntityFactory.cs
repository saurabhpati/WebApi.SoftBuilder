using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    /// <summary>
    /// The factory to manufacture the display data entity.
    /// </summary>
    public class DisplayDataEntityFactory : IEntityFactory<DisplayDataEntity>
    {
        /// <summary>
        /// Gets the manufactured entity for display data.
        /// </summary>
        /// <returns>The display data entity.</returns>
        public DisplayDataEntity GetEntity()
        {
            return new DisplayDataEntity();
        }
    }
}
