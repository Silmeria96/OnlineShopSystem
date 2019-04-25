using OnlineShopSystem.BLL.Account;
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
    // 用户帐号控制器
    public class AccountController : Controller
    {
        // 首页
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account");
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

            var loginResult = CustomerLoginHelper.TryLogin(model.LoginAccount, model.LoginPassword);

            if (loginResult.State)
            {
                // 验证通过，设置登录Session
                FormsAuthentication.SetAuthCookie(loginResult.UserDisplayName, false);
                Session["UserAccount"] = loginResult.UserAccount;
                Session["UserDisplayName"] = loginResult.UserDisplayName;

                // 返回登录结果
                result = Json(new
                {
                    flag = true,
                    message = loginResult.Message,
                    token = "#123456"
                });
            }
            else
            {
                // 验证失败，清除登录Session
                Session.Remove("UserAccount");
                Session.Remove("UserDisplayName");

                // 返回登录结果
                result = Json(new
                {
                    flag = false,
                    message = loginResult.Message,
                });
            }

            return result;
        }

        // 登出
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            Session.Remove("UserAccount");
            Session.Remove("UserDisplayName");

            return RedirectToAction("Login", "Account");
        }

        // 注册页面
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // 尝试注册
        [HttpPost]
        public ActionResult Register(CustomerRegisterModel model)
        {
            var registerResult = CustomerRegisterHelper.TryRegister(model.Account, model.Password);

            return View(registerResult);
        }

    }
}