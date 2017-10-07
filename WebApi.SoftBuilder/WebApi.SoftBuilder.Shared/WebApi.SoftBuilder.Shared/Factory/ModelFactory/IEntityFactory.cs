using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Shared.Factory.ModelFactory
{
    /// <summary>
    /// The contract that a factory has to implement to be an entity factory for all entities related to any entity or content in the application
    /// </summary>
    /// <typeparam name="T">Any entity, model or content within the application.</typeparam>
    public interface IEntityFactory<T> where T : IClientModel
    {
    }
}
