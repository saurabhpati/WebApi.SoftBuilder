using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared.Form;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Shared.Form;

namespace WebApi.SoftBuilder.Implementation.Service
{
    public class ContactSectionDataService<T> : HomePageDataServiceBase<T> where T : ContactEntity, new()
    {
        private IHomeEntityFactory homeEntityFactory;
        private IFormEntityFactory formEntityFactory;

        public ContactSectionDataService()
        {
            this.homeEntityFactory = new HomeEntityFactory();
            this.formEntityFactory = new FormEntityFactory();
        }

        /// <summary>
        /// Gets the data for the contact section in the home page.
        /// </summary>
        /// <returns>contact model containing the data for the contact section in the home page.</returns>
        public override T GetSectionData()
        {
            T contactEntity = this.homeEntityFactory.GetContactEntity() as T;
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
