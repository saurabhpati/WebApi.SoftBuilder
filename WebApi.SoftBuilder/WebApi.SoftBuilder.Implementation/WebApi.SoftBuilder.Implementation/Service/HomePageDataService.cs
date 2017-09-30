using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Shared.Model;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Service
{
    /// <summary>
    /// The service class that gets the data for the home page.
    /// </summary>
    public class HomePageDataService : IHomePageDataService
    {
        #region Public Methods

        /// <summary>
        /// Gets the data for the about section in the home page.
        /// </summary>
        /// <returns>about model containing the data for the about section in the home page.</returns>
        public IClientModel GetAboutData()
        {
            return new AboutEntity()
            {
                Id = "about",
                Name = "About",
                DisplayDataList = new List<DisplayDataEntity>()
                {
                    new DisplayDataEntity()
                    {
                        Class = "col-lg-4 ml-auto",
                        Data = @"Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source
                                files including HTML, CSS, and JavaScript as well as optional LESS stylesheets for easy customization."
                    },
                    new DisplayDataEntity()
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
        public IClientModel GetContactData()
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
            };
        }

        #endregion
    }
}
