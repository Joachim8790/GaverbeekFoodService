using System.Web;
using System.Web.Optimization;

namespace De_Gaverbeek
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/Site.js", 
                      "~/semantic/dist/semantic.min.js",
                      "~/Scripts/jquery.slitslider.js",
                      "~/Scripts/jquery.ba-cond.min.js"


                      ));
 

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-theme.min.css",
                      "~/semantic/dist/semantic.min.css",
                      "~/Content/Site.css",
                      "~/Content/style.css",
                      "~/Content/demo.css",
                      "~/Content/custom.css"

                      ));
            //DataTables
            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                "~/Scripts/DataTables/jquery.datatables.min.js",
                "~/Scripts/DataTables/datatables.bootstrap.min.js",
                "~/Scripts/DataTables/datatables.responsive.min.js"
                ));
            bundles.Add(new StyleBundle("~/Content/datatables").Include(
                "~/Content/DataTables/css/dataTables.bootstrap.min.css",
                "~/Content/DataTables/css/responsive.bootstrap.min.css"));

        }
    }
}
