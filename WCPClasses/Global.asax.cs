﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WCPClasses
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            
            RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
        }
    }
}
