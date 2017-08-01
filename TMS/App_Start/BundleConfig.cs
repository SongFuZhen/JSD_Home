using System.Web;
using System.Web.Optimization;

namespace TMS
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery-ui.js"
                        ));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                        "~/Scripts/jquery-jvectormap-2.0.3.min.js",
                        "~/Scripts/jquery-jvectormap-world-mill-en.js",
                        "~/Scripts/jquery-jvectormap-cn-mill.js",
                        "~/Scripts/jquery.easing.min.js",
                        "~/Scripts/jquery.validate-vsdoc.js",
                        "~/Scripts/jquery.vegas.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/jquery.singlePageNav.js",
                        "~/Scripts/jquery.flexslider.js",
                        "~/Scripts/jquery.prettyPhoto.js",
                        "~/Scripts/logging.js"
                      ));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css",
                      "~/Content/animate.css",
                      "~/Content/jquery-jvectormap-1.2.2.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/owl.theme.default.min.css",
                      "~/Content/icomoon.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/adminLTE").Include(
                      "~/Scripts/AdminLTE/adminLET.js"));

            bundles.Add(new StyleBundle("~/Content/adminLTE").Include(
                      "~/Content/AdminLTE.css",
                      "~/Content/all-skins.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/page1").Include(
                     "~/Scripts/page1.js"));

            bundles.Add(new StyleBundle("~/Content/page1").Include(
                      "~/Content/page1.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/page2").Include(
                    "~/Scripts/page2.js"));

            bundles.Add(new StyleBundle("~/Content/page2").Include(
                      "~/Content/page2.css"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/page3").Include(
                   "~/Scripts/page3.js"));

            bundles.Add(new StyleBundle("~/Content/page3").Include(
                      "~/Content/templatemo_misc.css",
                      "~/Content/page3.css"
                      ));
        }
    }
}
