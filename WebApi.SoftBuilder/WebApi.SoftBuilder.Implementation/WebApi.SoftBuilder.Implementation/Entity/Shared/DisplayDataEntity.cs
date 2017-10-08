using Newtonsoft.Json;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Shared
{
    /// <summary>
    /// The shared display model eventually consumed by client.
    /// </summary>
    public class DisplayDataEntity : ClientModelBase
    {
        /// <summary>
        /// The html class attribute for the section.
        /// </summary>
        [JsonProperty("class", NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        /// <summary>
        /// The data that needs to be displayed to the user.
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }
    }
}
