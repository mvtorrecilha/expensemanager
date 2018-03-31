using System.Web;
using System.Web.Optimization;

namespace ExpenseManager.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/moment.js",
                      "~/Scripts/bootstrap-datetimepicker.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-datetimepicker.min.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                     "~/Scripts/angular.min.js",
                     "~/Scripts/angular-route.min.js",

                     "~/Scripts/App/AppConfig.js",
                     "~/Scripts/App/Controllers/Expense/Index.js",
                     "~/Scripts/App/Controllers/Expense/Create.js",
                     "~/Scripts/App/Controllers/Expense/Update.js",
                     "~/Scripts/App/Controllers/Expense/Delete.js",

                     "~/Scripts/App/Services/ExpenseService.js",
                     "~/Scripts/App/Services/CategoryService.js",

                      "~/Scripts/App/Directives/DateTimeDirective.js",
                      "~/Scripts/App/Filters/DateTimeFilter.js"
                     ));
        }
    }
}
