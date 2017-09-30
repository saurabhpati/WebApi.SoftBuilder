using Newtonsoft.Json;
using WebApi.SoftBuilder.Models.Base;
using WebApi.SoftBuilder.Models.Shared.Form;

namespace WebApi.SoftBuilder.Models.Home
{
    /// <summary>
    /// The model data container for the contact section of the home page.
    /// </summary>
    public class ContactModel : ClientModelBase
    {
        /// <summary>
        /// Gets or sets the contact form.
        /// </summary>
        [JsonProperty("contactForm", NullValueHandling = NullValueHandling.Ignore)]
        public FormModel ContactForm { get; set; }
    }
}