using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.SoftBuilder.Models.Base;
using WebApi.SoftBuilder.Models.Shared;

namespace WebApi.SoftBuilder.Models.Home
{
    /// <summary>
    /// The model data container for about section of the home page.
    /// </summary>
    public class AboutModel : ClientModelBase
    {
        /// <summary>
        /// Gets or sets the list of data to be displayed by the client.
        /// </summary>
        [JsonProperty("displaydatas", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DisplayDataModel> DisplayDataList { get; set; }
    }
}