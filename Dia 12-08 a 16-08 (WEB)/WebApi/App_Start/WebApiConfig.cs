using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApi            //só liberar acesso para nossa api não para a pagina inteira
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors();                            //Cors para chamar o que foi instalado

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
