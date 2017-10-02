using System.Collections.Generic;
using WebApi.SoftBuilder.Implementation.Entity.Home;
using WebApi.SoftBuilder.Implementation.Entity.Shared;

namespace WebApi.SoftBuilder.Implementation.Service
{
    /// <summary>
    /// The service class that gets the data for the home page.
    /// </summary>
    public class AboutSectionDataService<T> : HomePageDataServiceBase<T> where T : AboutEntity, new()
    {
        #region Public Methods

        /// <summary>
        /// Gets the data for the about section in the home page.
        /// </summary>
        /// <returns>about model containing the data for the about section in the home page.</returns>
        public override T GetSectionData()
        {
            return new T()
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

            #endregion

        }
    }
}
