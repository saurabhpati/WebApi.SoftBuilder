using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    /// <summary>
    /// The factory to manufacture the display data entity.
    /// </summary>
    public class DisplayDataEntityFactory : EntityFactory
    {
        /// <summary>
        /// Gets the manufactured entity for display data.
        /// </summary>
        /// <returns>The display data entity.</returns>
        public override ClientModelBase GetEntity()
        {
            return new DisplayDataEntity();
        }
    }
}
