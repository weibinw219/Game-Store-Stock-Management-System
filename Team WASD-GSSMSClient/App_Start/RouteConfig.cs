using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Team_WASD_GSSMSClient
{
    public class RouteConfig
    {
        /*
         * Author: Liashova Elizabeta
         */
        /// <summary>
        /// Default routes setting of the application
        /// </summary>
        /// <param name="routes">An instance of RouteCollection</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Use Home controller and Index page as the default application starting page
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
