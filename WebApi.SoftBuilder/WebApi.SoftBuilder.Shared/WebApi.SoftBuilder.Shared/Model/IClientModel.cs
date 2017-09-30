namespace WebApi.SoftBuilder.Shared.Model
{
    /// <summary>
    /// The contract for exported shared client model .
    /// </summary>
    public interface IClientModel
    {
        /// <summary>
        /// Gets or sets the id of the client model.
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the client model.
        /// </summary>
        string Name { get; set; }
    }
}
