using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    public class ShopCartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart()
        {
            return View();
        }
    }
}