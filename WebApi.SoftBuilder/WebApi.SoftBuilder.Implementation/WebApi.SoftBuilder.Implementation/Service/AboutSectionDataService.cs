using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory;
using WebApi.SoftBuilder.Implementation.Factory.EntityFactory.Home;
using WebApi.SoftBuilder.Shared.Service;

namespace WebApi.SoftBuilder.Implementation.Service
{
    /// <summary>
    /// The service class that gets the data for the home page.
    /// </summary>
    public class AboutSectionDataService<T> : IHomePageDataService<T> where T : AboutEntity, new()
    {
        private DisplayDataEntityFactory displayDataEntityFactory;
        private IHomeEntityFactory homeEntityFactory;

        public AboutSectionDataService()
        {
            this.displayDataEntityFactory = new DisplayDataEntityFactory();
            this.homeEntityFactory = new HomeEntityFactory();
        }

        #region Public Methods

        /// <summary>
        /// Gets the data for the about section in the home page.
        /// </summary>
        /// <returns>about model containing the data for the about section in the home page.</returns>
        public T GetSectionData()
        {
            T aboutEntity = this.homeEntityFactory.GetAboutEntity() as T;
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
         
        #endregion
    }
}
