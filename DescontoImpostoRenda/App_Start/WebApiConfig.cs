using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DescontoImpostoRenda
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "ImpostoRenda",
                routeTemplate: "api/salario/imposto-renda/{salario}",
                defaults: new { controller = "Salario", action = "ImpostoRenda", salario = RouteParameter.Optional }
            );


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
