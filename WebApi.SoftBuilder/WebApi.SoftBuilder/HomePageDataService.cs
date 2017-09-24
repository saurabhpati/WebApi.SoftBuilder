using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.SoftBuilder.Models.Home;
using WebApi.SoftBuilder.Models.Shared;

namespace WebApi.SoftBuilder
{
    public class HomePageDataService
    {
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
    }
}