using System.Web;
using System.Web.Optimization;

namespace Menporul.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            //Jquery JS
            bundles.Add(new ScriptBundle("~/JQuery/js").Include(
                      "~/assets/plugins/jquery/jquery.min.js"));
            //Popper JS
            bundles.Add(new ScriptBundle("~/Popper/js").Include(
                      "~/assets/plugins/popper/popper.min.js"));
            //Bootstrap JS
            bundles.Add(new ScriptBundle("~/Bootstrap/js").Include(
                      "~/assets/plugins/bootstrap/js/bootstrap.min.js"));
            //SlimScroll  JS
            bundles.Add(new ScriptBundle("~/SlimScroll/js").Include(
                      "~/js/jquery.slimscroll.js"));
            //Wave effects JS
            bundles.Add(new ScriptBundle("~/Wave/js").Include(
                      "~/js/waves.js"));
            //Sidebarmenu  JS
            bundles.Add(new ScriptBundle("~/Sidebarmenu/js").Include(
                      "~/js/sidebarmenu.js"));
            //stickey  JS
            bundles.Add(new ScriptBundle("~/Stickey/js").Include(
                      "~/assets/plugins/sticky-kit-master/dist/sticky-kit.min.js",
                      "~/assets/plugins/sparkline/jquery.sparkline.min.js"));
            //Custom  JS
            bundles.Add(new ScriptBundle("~/Custom/js").Include(
                      "~/js/custom.min.js"));
           
            //Chartlist JS
            bundles.Add(new ScriptBundle("~/Chartlist/js").Include(
                      "~/assets/plugins/chartist-js/dist/chartist.min.js",
                      "~/assets/plugins/chartist-plugin-tooltip-master/dist/chartist-plugin-tooltip.min.js"));
            // C3 JS
            bundles.Add(new ScriptBundle("~/c3/js").Include(
                     "~/assets/plugins/d3/d3.min.js",
                     "~/assets/plugins/c3-master/c3.min.js"));
            //Chart Dashboard JS
            bundles.Add(new ScriptBundle("~/Dashboard1/chart").Include(
                      "~/js/dashboard1.js"));
            //Style Switcher JS
            bundles.Add(new ScriptBundle("~/Style/Switcher").Include(
                      "~/assets/plugins/styleswitcher/jQuery.style.switcher.js"));


            //Bootstrap CSS
            bundles.Add(new StyleBundle("~/Bootstrap/css").Include(
                      "~/assets/plugins/bootstrap/css/bootstrap.min.css"));
            // Chartlist css
            bundles.Add(new StyleBundle("~/Chartist/css").Include(
                     "~/assets/plugins/chartist-js/dist/chartist.min.css",
                     "~/assets/plugins/chartist-js/dist/chartist-init.css",
                     "~/assets/plugins/chartist-plugin-tooltip-master/dist/chartist-plugin-tooltip.css"
                     ));
            // Morris CSS
            bundles.Add(new StyleBundle("~/Morris/css").Include(
                      "~/assets/plugins/c3-master/c3.min.css"));
            // Custom CSS
            bundles.Add(new StyleBundle("~/Custom/css").Include(
                      "~/css/style.css"));
            // Theme Blue CSS
            bundles.Add(new StyleBundle("~/Theme/blue").Include(
                      "~/css/colors/blue.css"));
        }
    }
}
