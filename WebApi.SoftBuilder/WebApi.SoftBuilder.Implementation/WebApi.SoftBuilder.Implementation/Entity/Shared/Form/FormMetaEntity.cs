using Newtonsoft.Json;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Shared.Form
{
    /// <summary>
    /// The shared data container for other meta data of the form
    /// </summary>
    public class FormMetaEntity : ClientModelBase
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
