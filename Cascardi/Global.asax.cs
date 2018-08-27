﻿using Hangfire;
using Owin;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cascardi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("CascardiContext");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
