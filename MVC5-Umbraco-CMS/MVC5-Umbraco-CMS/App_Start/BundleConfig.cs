using System.Web.Optimization;

namespace MVC5_Umbraco_CMS
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-directives").Include(
                      "~/Scripts/angular-animate.min.js",
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/ui-bootstrap-csp.css",
                      "~/css/main.css"));
        }
    }
}