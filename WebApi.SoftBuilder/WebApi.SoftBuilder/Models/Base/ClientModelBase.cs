using Newtonsoft.Json;

namespace WebApi.SoftBuilder.Models.Base
{
    /// <summary>
    /// The base model for any of the client model.
    /// </summary>
    public class ClientModelBase
    {
        /// <summary>
        /// Gets or sets the id for all the models to be used by client models.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name for all the models to be used by any client models.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }
}