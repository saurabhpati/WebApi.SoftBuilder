using WebApi.SoftBuilder.Implementation.Model;
using WebApi.SoftBuilder.Shared.Factory.ModelFactory;

namespace WebApi.SoftBuilder.Implementation.Factory.EntityFactory
{
    /// <summary>
    /// The common entity factory that manufactures the minimalistic base model for the client i.e. the base client model.
    /// </summary>
    public class EntityFactory : IEntityFactory<ClientModelBase>
    {
        /// <summary>
        /// Gets the common minimalistic model for the client i.e. the base client model.
        /// </summary>
        /// <returns>The client base model.</returns>
        public virtual ClientModelBase GetEntity()
        {
            return new ClientModelBase();
        }
    }
}
