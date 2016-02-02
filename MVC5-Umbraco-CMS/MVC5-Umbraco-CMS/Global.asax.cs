using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Optimization;
using Umbraco.Web;

namespace MVC5_Umbraco_CMS
{
    public class Global : UmbracoApplication
    {
        public void Init(HttpApplication application)
        {
            application.PreRequestHandlerExecute += application_PreRequestHandlerExecute;
            application.BeginRequest += Application_BeginRequest;
            application.EndRequest += Application_EndRequest;
            application.Error += Application_Error;
        }

        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void application_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            try
            {
                if (Session.IsNewSession)
                {
                    // Your code here
                }
            }
            catch
            {
                // ignored
            }
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            try
            {
                // You begin request code here
            }
            catch
            {
                // ignored
            }
        }

        private void Application_EndRequest(object sender, EventArgs e)
        {
            // Your code here
        }

        protected new void Application_Error(object sender, EventArgs e)
        {
            // Your error handling here
        }
    }
}