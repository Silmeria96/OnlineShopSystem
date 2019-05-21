using OnlineShopSystem.BLL.Production;
using OnlineShopSystem.BLL.Search;
using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 首页控制器
    /// </summary>
    public class HomeController : Controller
    {
        private SysContext db = new SysContext();
        private ProductHelper productHelper = new ProductHelper();

        /// <summary>
        /// 网站首页
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Index(int? pageSize = 10, int? pageIndex = 1)
        {
            ViewBag.ProductList = productHelper.GetPagedProductList((int)pageSize, (int)pageIndex);
            return View();
        }



    }
}