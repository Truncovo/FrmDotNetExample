﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FrmDotNetExample.Helpers;

namespace FrmDotNetExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            CshtmlHelper.Init(Server);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
