using System.Web;
using System.Web.Optimization;

namespace JobPoratal_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootsrapPulse.min.css", "~/Content/site.css"
                ));

            #region Template design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                         "~/Scripts/js/bootstrap-4.1.3.min.js",
                         "~/Scripts/js/gmaps.min.js",
                         "~/Scripts/js/jquery-2.2.4.min.js",
                         "~/Scripts/js/jquery.nice-select.min.js",
                         "~/Scripts/js/owl-carousel.min.js",
                         "~/Scripts/js/wow.min.js",
                         "~/Scripts/js/main.js"



                       ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                "~/ Content/css/animate- 3.7.0.css",
                "~/Content/css/bootstrap-4.1.3.min.css",
                "~/Content/css/font-awesome-4.7.0.min.css",
                "~/Content/css/ion.rangeSlider.css",
                "~/Content/css/nice-select.css",
                "~/Content/css/owl-carousel.min.css",
                "~/Content/css/style.css"

                ));

            #endregion
        }
    }
}
