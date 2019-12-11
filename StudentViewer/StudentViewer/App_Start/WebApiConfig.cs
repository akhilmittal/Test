using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using StudentViewer.CustomFilters;

namespace StudentViewer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new CustomExceptionFilter());
            config.Filters.Add(new BasicAuthenticationFilter());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
