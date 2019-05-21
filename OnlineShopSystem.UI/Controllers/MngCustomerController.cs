using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 用户账户控制器
    /// </summary>
    public class MngCustomerController : Controller
    {
        // 首页
        public ActionResult Index()
        {
            return View();
        }
    }
}