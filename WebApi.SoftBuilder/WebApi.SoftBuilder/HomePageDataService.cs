using System.Collections.Generic;
using WebApi.SoftBuilder.Models.Home;
using WebApi.SoftBuilder.Models.Shared;
using WebApi.SoftBuilder.Models.Shared.Form;

namespace WebApi.SoftBuilder
{
    /// <summary>
    /// The service class that gets the data for the home page.
    /// </summary>
    public class HomePageDataService
    {
        #region Public Methods

        /// <summary>
        /// Gets the data for the about section in the home page.
        /// </summary>
        /// <returns>about model containing the data for the about section in the home page.</returns>
        public AboutModel GetAboutData()
        {
            return new AboutModel()
            {
                Id = "about",
                Name = "About",
                DisplayDataList = new List<DisplayDataModel>()
                {
                    new DisplayDataModel()
                    {
                        Class = "col-lg-4 ml-auto",
                        Data = @"Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source
                                files including HTML, CSS, and JavaScript as well as optional LESS stylesheets for easy customization."
                    },
                    new DisplayDataModel()
                    {
                        Class = "col-lg-4 mr-auto",
                        Data = @"Whether you're a student looking to showcase your work, a professional looking to attract clients, or a graphic\
                                artist looking to share your projects, this template is the perfect starting point!"
                    }
                }
            };
        }

        /// <summary>
        /// Gets the data for the contact section in the home page.
        /// </summary>
        /// <returns>contact model containing the data for the contact section in the home page.</returns>
        public ContactModel GetContactData()
        {
            return new ContactModel()
            {
                Id = "contact",
                Name = "Contact Me",
                ContactForm = new FormModel()
                {
                    Id = "contactForm",
                    Fields = new List<FieldModel>()
                    {
                        new FieldModel()
                        {
                            Id = "name",
                            Name = "Name",
                            FieldType = "input",
                            InputType = "text",
                            PlaceHolder = "Name",
                            IsRequired = true,
                            ValidationMessage = "Please enter your name."
                        },
                        new FieldModel()
                        {
                            Id = "email",
                            Name = "Email Address",
                            FieldType = "input",
                            InputType = "email",
                            PlaceHolder = "Email Address",
                            IsRequired = true,
                            ValidationMessage = "Please enter your email address."
                        },
                        new FieldModel()
                        {
                            Id = "phone",
                            Name = "Phone Number",
                            FieldType = "input",
                            InputType = "tel",
                            PlaceHolder = "Phone Number",
                            IsRequired = true,
                            ValidationMessage = "Please enter your phone number."
                        },
                        new FieldModel()
                        {
                            Id = "message",
                            Name = "Message",
                            FieldType = "textarea",
                            InputType = "tel",
                            PlaceHolder = "Message",
                            IsRequired = true,
                            ValidationMessage = "Please enter a message.",
                            FieldMetaList = new List<FormMetaModel>()
                            {
                                new FormMetaModel()
                                {
                                    Type = "row",
                                    Value = "5"
                                }
                            }
                        }
                    }
                }
            };
        }

        #endregion
    }
}