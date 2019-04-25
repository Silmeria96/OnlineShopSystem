using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    public class SearchController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index(string keyword)
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Detail(int? id)
        {
            ViewBag.Title = "化妆品";  // 网页标题

            return View();
        }
    }
}