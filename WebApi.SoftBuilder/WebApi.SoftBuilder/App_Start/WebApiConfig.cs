﻿using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Practices.Unity;

namespace WebApi.SoftBuilder
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // CORS is to remove the 'No-Access-Control-Origin' Header present issue.
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            #region Unity Registration

            IUnityContainer container = new UnityContainer();
            WebApi.SoftBuilder.Implementation.ContainerRegistration.RegisterTypes(container);
            ContainerRegistration.RegisterTypes(container);
            config.DependencyResolver = new UnityResolver(container);

            #endregion
        }
    }
}
