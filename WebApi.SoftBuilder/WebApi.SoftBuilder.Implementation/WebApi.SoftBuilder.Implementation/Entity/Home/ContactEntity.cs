using Newtonsoft.Json;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Implementation.Model;

namespace WebApi.SoftBuilder.Implementation.Entity.Home
{
    /// <summary>
    /// The model data container for the contact section of the home page.
    /// </summary>
    public class ContactEntity : ClientModelBase, IHomeEntity
    {
        /// <summary>
        /// Gets or sets the contact form.
        /// </summary>
        [JsonProperty("contactForm", NullValueHandling = NullValueHandling.Ignore)]
        public FormEntity ContactForm { get; set; }
    }
}
