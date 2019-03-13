using OnlineShopSystem.Model;
using OnlineShopSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShopSystem.UI.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // 登录页面
        [AllowAnonymous]
        public ActionResult Login()
        {
            using (SysContext db = new SysContext())
            {
                var result = db.Customers.ToList();
            }

            return View();
        }

        // 尝试登录
        [HttpPost]
        public JsonResult Login(CustomerLoginModel model)
        {
            var result = new JsonResult();

            if (model.LoginAccount == "sa" && model.LoginPassword == "sa")
            {
                // 验证通过，设置登录Cookie
                FormsAuthentication.SetAuthCookie(model.LoginAccount, true);

                // 返回登录结果
                result = Json(new
                {
                    flag = true,
                    token = "#123456"
                });
            }
            else
            {
                // 验证失败，清除登录Cookie
                FormsAuthentication.SetAuthCookie(model.LoginAccount, false);

                // 返回登录结果
                result = Json(new
                {
                    flag = false,
                    errorMsg = "登录失败！"
                });
            }

            return result;
        }

        // 注册页面
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }


    }
}