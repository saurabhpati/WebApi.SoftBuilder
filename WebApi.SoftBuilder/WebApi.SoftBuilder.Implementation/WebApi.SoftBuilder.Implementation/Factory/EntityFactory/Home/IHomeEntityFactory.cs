using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    /// <summary>
    /// The contract that a factory has to implement to be a entity factory for all entities related to contents or data for the home page.
    /// </summary>
    public interface IHomeEntityFactory : IEntityFactory<HomeEntity>
    {
        /// <summary>
        /// Gets the manufactured about entity in the form of home entity.
        /// </summary>
        /// <returns>The about entity.</returns>
        HomeEntity GetAboutEntity();

        /// <summary>
        /// Gets the manufactured contact entity in the form of home entity.
        /// </summary>
        /// <returns>The contact entity.</returns>
        HomeEntity GetContactEntity();
    }
}
