﻿namespace WebApplication1
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Improve SEO by stopping duplicate URL's due to case differences or trailing slashes.
            // See http://googlewebmastercentral.blogspot.co.uk/2010/04/to-slash-or-not-to-slash.html
            routes.AppendTrailingSlash = true;
            routes.LowercaseUrls = true;

            // IgnoreRoute - Tell the routing system to ignore certain routes for better performance.
            // Ignore .axd files.
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Ignore everything in the Content folder.
            routes.IgnoreRoute("Content/{*pathInfo}");
            // Ignore everything in the Scripts folder.
            routes.IgnoreRoute("Scripts/{*pathInfo}");
            // Ignore the Forbidden.html file.
            routes.IgnoreRoute("Error/Forbidden.html");
            // Ignore the GatewayTimeout.html file.
            routes.IgnoreRoute("Error/GatewayTimeout.html");
            // Ignore the ServiceUnavailable.html file.
            routes.IgnoreRoute("Error/ServiceUnavailable.html");
            // Ignore the humans.txt file.
            routes.IgnoreRoute("humans.txt");

            // Enable attribute routing.
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "HomeIndex",
                url: "",
                defaults: new { controller = "Home", action = "Index" });
        }
    }
}
