using Newtonsoft.Json;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Home
{
    /// <summary>
    /// The model data container for the contact section of the home page.
    /// </summary>
    public class ContactEntity : HomeEntity
    {
        /// <summary>
        /// Gets or sets the contact form.
        /// </summary>
        [JsonProperty("contactForm", NullValueHandling = NullValueHandling.Ignore)]
        public FormEntity ContactForm { get; set; }
    }
}
