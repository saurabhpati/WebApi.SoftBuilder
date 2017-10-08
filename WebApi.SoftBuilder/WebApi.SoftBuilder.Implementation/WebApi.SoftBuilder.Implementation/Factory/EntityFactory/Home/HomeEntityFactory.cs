using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    /// <summary>
    /// The factory that manufactures the entities related to the home page.
    /// </summary>
    public class HomeEntityFactory : IHomeEntityFactory
    {
        /// <summary>
        /// Gets the manufactured about entity in the form of home entity.
        /// </summary>
        /// <returns>The about entity.</returns>
        public HomeEntity GetAboutEntity()
        {
            return new AboutEntity();
        }

        /// <summary>
        /// Gets the manufactured contact entity in the form of home entity.
        /// </summary>
        /// <returns>The contact entity.</returns>
        public HomeEntity GetContactEntity()
        {
            return new ContactEntity();
        }

        public HomeEntity GetEntity()
        {
            return new HomeEntity();
        }
    }
}
