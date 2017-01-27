using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace De_Gaverbeek
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Main",
                url: "{controller}",
                defaults: new { controller = "Main", action = "Index" }
                );
            routes.MapRoute(
               name: "cms",
               url: "{controller}/{action}",
               defaults: new { controller = "Main1", action = "Index" }
               );
            routes.MapRoute(
                name: "ProductDetails",
                url: "{controller}/{id}",
                defaults: new { controller = "Main", action = "Index" }
        
                );
            
            
        }
    }
}
