using System.Web.Optimization;
using Umbraco.Core;

namespace MVC5_Umbraco_CMS
{
    public class UmbracoEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);    
        } 
    }
}