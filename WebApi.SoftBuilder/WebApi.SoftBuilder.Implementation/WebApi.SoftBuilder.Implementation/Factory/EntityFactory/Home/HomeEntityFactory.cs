using WebApi.SoftBuilder.Implementation.Entity.Home;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    public class HomeEntityFactory : IHomeEntityFactory
    {
        public IHomeEntity GetAboutEntity()
        {
            return new AboutEntity();
        }

        public IHomeEntity GetContactEntity()
        {
            return new ContactEntity();
        }
    }
}
