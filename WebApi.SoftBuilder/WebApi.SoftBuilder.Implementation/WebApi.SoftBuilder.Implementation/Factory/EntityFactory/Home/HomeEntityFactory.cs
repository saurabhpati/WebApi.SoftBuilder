using WebApi.SoftBuilder.Implementation.Entity.Home;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    public class HomeEntityFactory : IHomeEntityFactory
    {
        public HomeEntity GetAboutEntity()
        {
            return new AboutEntity();
        }

        public HomeEntity GetContactEntity()
        {
            return new ContactEntity();
        }
    }
}
