﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFistHelloWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //routes.MapRoute("View", "View/ViewCustomer/{id}",
            //    new
            //    {
            //        Controller = "Customer",
            //        Action = "DisplayCustomer",
            //        id = 0
            //    }, new {id = @"\d{1,2}"});
        }
    }
}
