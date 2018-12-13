using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using TourAgencyServer.Models;

namespace TourAgencyServer
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
           // System.Data.Entity.Database.SetInitializer

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}