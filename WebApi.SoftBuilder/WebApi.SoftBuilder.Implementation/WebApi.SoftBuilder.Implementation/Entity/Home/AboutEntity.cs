using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Home
{
    /// <summary>
    /// The entity data container for about section of the home page.
    /// </summary>
    public class AboutEntity : ClientModelBase, IHomeEntity
    {
        /// <summary>
        /// Gets or sets the list of data to be displayed by the client.
        /// </summary>
        [JsonProperty("displaydatas", NullValueHandling = NullValueHandling.Ignore)]
        public IList<DisplayDataEntity> DisplayDataList { get; set; }
    }
}
