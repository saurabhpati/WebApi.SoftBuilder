using System.Collections.Generic;
using Newtonsoft.Json;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Shared.Form
{
    /// <summary>
    /// The shared model container for a particular field in a form in the application.
    /// </summary>
    public class FieldEntity : ClientModelBase, IFormEntity
    {
        /// <summary>
        /// Gets or sets the field type of the field. e.g. 'input'/'textarea'.
        /// </summary>
        [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// Gets or sets the field input type of the field. e.g. 'text'/'email'.
        /// </summary>
        [JsonProperty("inputType", NullValueHandling = NullValueHandling.Ignore)]
        public string InputType { get; set; }

        /// <summary>
        /// Gets or sets the placeholder if any for the field.
        /// </summary>
        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceHolder { get; set; }

        /// <summary>
        /// Gets or sets a value whether the field is a required field or not, true if required, false otherwise.
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the validation message if the field is required i.e. if IsRequired = true
        /// </summary>
        [JsonProperty("validationMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationMessage { get; set; }

        /// <summary>
        /// Gets or sets the other field meta deta for the form
        /// </summary>
        [JsonProperty("fieldMetas", NullValueHandling = NullValueHandling.Ignore)]
        public IList<FormMetaEntity> FieldMetaList { get; set; }
    }
}
