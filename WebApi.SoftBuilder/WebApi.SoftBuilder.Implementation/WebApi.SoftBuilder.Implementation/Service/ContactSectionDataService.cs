using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;

namespace WebApi.SoftBuilder.Implementation.Service
{
    public class ContactSectionDataService<T> : HomePageDataServiceBase<T> where T : ContactEntity
    {
        /// <summary>
        /// Gets the data for the contact section in the home page.
        /// </summary>
        /// <returns>contact model containing the data for the contact section in the home page.</returns>
        public override T GetSectionData()
        {
            return new ContactEntity()
            {
                Id = "contact",
                Name = "Contact Me",
                ContactForm = new FormEntity()
                {
                    Id = "contactForm",
                    Fields = new List<FieldEntity>()
                    {
                        new FieldEntity()
                        {
                            Id = "name",
                            Name = "Name",
                            FieldType = "input",
                            InputType = "text",
                            PlaceHolder = "Name",
                            IsRequired = true,
                            ValidationMessage = "Please enter your name."
                        },
                        new FieldEntity()
                        {
                            Id = "email",
                            Name = "Email Address",
                            FieldType = "input",
                            InputType = "email",
                            PlaceHolder = "Email Address",
                            IsRequired = true,
                            ValidationMessage = "Please enter your email address."
                        },
                        new FieldEntity()
                        {
                            Id = "phone",
                            Name = "Phone Number",
                            FieldType = "input",
                            InputType = "tel",
                            PlaceHolder = "Phone Number",
                            IsRequired = true,
                            ValidationMessage = "Please enter your phone number."
                        },
                        new FieldEntity()
                        {
                            Id = "message",
                            Name = "Message",
                            FieldType = "textarea",
                            InputType = "tel",
                            PlaceHolder = "Message",
                            IsRequired = true,
                            ValidationMessage = "Please enter a message.",
                            FieldMetaList = new List<FormMetaEntity>()
                            {
                                new FormMetaEntity()
                                {
                                    Type = "row",
                                    Value = "5"
                                }
                            }
                        }
                    }
                }
            } as T;
        }
    }
}
