using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("NewsByPublicationDate",
                "RssNews/Date/{year}/{month}",
                new { controller = "RssNews", action = "ByPublicationDate" } );
            routes.MapRoute("NewsByCategory",
            "RssNews/Category/{category}",
              new { controller = "RssNews", action = "ByCategory" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
