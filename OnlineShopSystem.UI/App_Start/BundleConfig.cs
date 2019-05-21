using System.Web;
using System.Web.Optimization;

namespace OnlineShopSystem.UI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.unobtrusive-ajax.js",
                      "~/Scripts/swiper.js",
                      "~/Scripts/respond.js"));

            // 通用
            bundles.Add(new StyleBundle("~/Content/Shared/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/Shared/top-header.css",
                    "~/Content/Shared/swiper.css",
                    "~/Content/iconfont/iconfont.css"
                ));

            // 首页
            bundles.Add(new StyleBundle("~/Content/Home/css").Include(
                    "~/Content/Home/main-header.css",
                    "~/Content/Home/home-slider.css",
                    "~/Content/Home/home-floors.css"
                ));
        }
    }
}
