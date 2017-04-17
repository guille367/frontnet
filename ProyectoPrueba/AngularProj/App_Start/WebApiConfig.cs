﻿using System.Web.Http;

class WebApiConfig
{
    public static void Register(HttpConfiguration configuration)
    {
        configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{action}/{id}",
            new { action = RouteParameter.Optional, id = RouteParameter.Optional });
    }
}