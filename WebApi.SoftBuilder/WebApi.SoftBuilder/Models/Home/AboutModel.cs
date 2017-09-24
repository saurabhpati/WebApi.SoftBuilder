using Newtonsoft.Json;
using System.Collections.Generic;
using WebApi.SoftBuilder.Models.Base;
using WebApi.SoftBuilder.Models.Shared;

namespace WebApi.SoftBuilder.Models.Home
{
    /// <summary>
    /// The model data container for about section of the home page.
    /// </summary>
    public class AboutModel : ClientModelBase
    {
        [JsonProperty("displaydatas", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DisplayDataModel> DisplayDataList { get; set; }
    }
}