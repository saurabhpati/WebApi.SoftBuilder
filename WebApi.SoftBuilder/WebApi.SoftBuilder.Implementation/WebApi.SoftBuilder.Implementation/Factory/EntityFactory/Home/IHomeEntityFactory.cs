using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home
{
    public interface IHomeEntityFactory : IEntityFactory<HomeEntity>
    {
        HomeEntity GetAboutEntity();

        HomeEntity GetContactEntity();
    }
}
