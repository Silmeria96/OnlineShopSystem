using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    // 管理员模块
    public class AdminController : Controller
    {
        // 管理员首页
        public ActionResult Index()
        {
            return View();
        }

        // 管理员登录页面
        public ActionResult AdminLogin()
        {
            return View();
        }

        // 管理员登录
        [HttpPost]
        public ActionResult AdminLogin(string account, string password)
        {
            return RedirectToAction("Index", "Admin");
        }

    }
}