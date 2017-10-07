using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Service
{
    /// <summary>
    /// The service that gives the data related to the home page.
    /// </summary>
    public class HomePageDataService : IHomePageDataService<HomeEntity>
    {
        private DisplayDataEntityFactory displayDataEntityFactory;
        private IHomeEntityFactory homeEntityFactory;
        private IFormEntityFactory formEntityFactory;

        /// <summary>
        /// The constructor to initialize the HomePageDataService class.
        /// </summary>
        public HomePageDataService()
        {
            this.displayDataEntityFactory = new DisplayDataEntityFactory();
            this.homeEntityFactory = new HomeEntityFactory();
            this.formEntityFactory = new FormEntityFactory();
        }

        /// <summary>
        /// Gets the data for the about section in the home page.
        /// </summary>
        /// <returns>about model containing the data for the about section in the home page.</returns>
        public HomeEntity GetAboutSectionData()
        {
            AboutEntity aboutEntity = this.homeEntityFactory.GetAboutEntity() as AboutEntity;
            aboutEntity.Id = "about";
            aboutEntity.Name = "About";
            List<DisplayDataEntity> displayDataList = new List<DisplayDataEntity>();
            DisplayDataEntity leftSideDisplayEntity = displayDataEntityFactory.GetEntity() as DisplayDataEntity;
            leftSideDisplayEntity.Class = "col-lg-4 ml-auto";
            leftSideDisplayEntity.Data = @"Freelancer is a free bootstrap theme created by Start Bootstrap. The download includes the complete source
                                          files including HTML, CSS, and JavaScript as well as optional LESS stylesheets for easy customization.";
            DisplayDataEntity rightSideDataEntity = displayDataEntityFactory.GetEntity() as DisplayDataEntity;
            rightSideDataEntity.Class = "col-lg-4 mr-auto";
            rightSideDataEntity.Data = @"Whether you're a student looking to showcase your work, a professional looking to attract clients, or a graphic\
                                        artist looking to share your projects, this template is the perfect starting point!";
            displayDataList.Add(leftSideDisplayEntity);
            displayDataList.Add(rightSideDataEntity);
            aboutEntity.DisplayDataList = displayDataList;
            return aboutEntity;
        }

        /// <summary>
        /// Gets the data for the contact section in the home page.
        /// </summary>
        /// <returns>contact model containing the data for the contact section in the home page.</returns>
        public HomeEntity GetContactSectionData()
        {
            ContactEntity contactEntity = this.homeEntityFactory.GetContactEntity() as ContactEntity;
            contactEntity.Id = "contact";
            contactEntity.Name = "Contact Me";
            List<FieldEntity> fields = new List<FieldEntity>();
            FieldEntity nameField = this.formEntityFactory.GetFieldEntity() as FieldEntity;
            nameField.Id = "name";
            nameField.Name = "Name";
            nameField.InputType = "text";
            nameField.FieldType = "input";
            nameField.PlaceHolder = "Name";
            nameField.IsRequired = true;
            nameField.ValidationMessage = "Please enter your name.";
            FieldEntity emailField = this.formEntityFactory.GetFieldEntity() as FieldEntity;
            emailField.Id = "email";
            emailField.Name = "Email Address";
            emailField.FieldType = "input";
            emailField.InputType = "email";
            emailField.PlaceHolder = "Email Address";
            emailField.IsRequired = true;
            emailField.ValidationMessage = "Please enter your email address.";
            FieldEntity phoneField = this.formEntityFactory.GetFieldEntity() as FieldEntity;
            phoneField.Id = "phone";
            phoneField.Name = "Phone Number";
            phoneField.FieldType = "input";
            phoneField.InputType = "tel";
            phoneField.PlaceHolder = "Phone Number";
            phoneField.IsRequired = true;
            phoneField.ValidationMessage = "Please enter your phone number.";
            FieldEntity messageField = this.formEntityFactory.GetFieldEntity() as FieldEntity;
            messageField.Id = "message";
            messageField.Name = "Message";
            messageField.FieldType = "textarea";
            messageField.PlaceHolder = "Message";
            messageField.IsRequired = true;
            messageField.ValidationMessage = "Please enter a message.";
            fields.Add(nameField);
            fields.Add(emailField);
            fields.Add(phoneField);
            fields.Add(messageField);
            List<FormMetaEntity> formMetas = new List<FormMetaEntity>();
            FormMetaEntity rowFormMeta = this.formEntityFactory.GetFormMetaEntity() as FormMetaEntity;
            rowFormMeta.Type = "row";
            rowFormMeta.Value = "5";
            formMetas.Add(rowFormMeta);
            messageField.FieldMetaList = formMetas;
            FormEntity contactFormEntity = this.formEntityFactory.GetFormEntity() as FormEntity;
            contactFormEntity.Fields = fields;
            contactEntity.ContactForm = contactFormEntity;
            return contactEntity;
        }
    }
}
