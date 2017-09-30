using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApi.SoftBuilder.Models.Base;

namespace WebApi.SoftBuilder.Models.Shared.Form
{
    /// <summary>
    /// The shared data container for other meta data of the form
    /// </summary>
    public class FormMetaModel : ClientModelBase
    {
        /// <summary>
        /// Gets or sets the type of the meta deta
        /// </summary>
        [JsonProperty("metatype")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the value of the meta data
        /// </summary>
        [JsonProperty("metavalue")]
        public string Value { get; set; }
    }
}