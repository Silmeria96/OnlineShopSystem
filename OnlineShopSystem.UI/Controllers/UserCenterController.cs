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
        // “个人中心”页面
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

        // “我的订单”页面
        public ActionResult OrderList()
        {
            return View();
        }

        // 个人信息
        public ActionResult MyInfoPatrial()
        {
            return PartialView("_MyInfoPatrial");
        }

        // 收获地址
        public ActionResult MyAdressPatrial()
        {
            return PartialView("_MyAddressPatrial");
        }
    }
}