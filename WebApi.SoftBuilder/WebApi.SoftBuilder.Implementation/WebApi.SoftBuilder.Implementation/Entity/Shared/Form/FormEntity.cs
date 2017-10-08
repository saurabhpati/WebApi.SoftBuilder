using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Shared.Form
{
    /// <summary>
    /// The shared model data container for a form in the application.
    /// </summary>
    public class FormEntity : ClientModelBase, IFormEntity
    {
        /// <summary>
        /// Gets or sets the list of fields in a form
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public IList<FieldEntity> Fields { get; set; }
    }
}
