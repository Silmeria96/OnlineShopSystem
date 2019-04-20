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
        // 个人中心首页
        public ActionResult Index()
        {
            // 显示用户昵称
            var userDisplayName = @Session["UserDisplayName"];
            if (userDisplayName != null)
            {
                ViewBag.UserDisplayName = userDisplayName.ToString();  
            }

            return View();
        }

        // 我的订单列表
        public ActionResult OrderList()
        {
            return View();
        }
    }
}