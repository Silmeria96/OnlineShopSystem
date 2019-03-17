using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    // 用户个人中心控制器
    public class UserCenterController : Controller
    {
        public ActionResult Index()
        {
            // 为个人中心提供用户昵称
            var userDisplayName = @Session["UserDisplayName"];
            if (userDisplayName != null)
            {
                ViewBag.UserDisplayName = userDisplayName.ToString();
            }

            return View();
        }
    }
}