using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.SoftBuilder.Models.Base;

namespace WebApi.SoftBuilder.Models.Shared.Form
{
    /// <summary>
    /// The shared model data container for a form in the application.
    /// </summary>
    public class FormModel : ClientModelBase
    {
        /// <summary>
        /// Gets or sets the list of fields in a form
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public IList<FieldModel> Fields { get; set; }
    }
}