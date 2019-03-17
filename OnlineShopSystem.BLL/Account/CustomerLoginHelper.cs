using OnlineShopSystem.BLL.Model;
using OnlineShopSystem.DAL;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Account
{
    /// <summary>
    /// 客户登录服务类
    /// </summary>
    public static class CustomerLoginHelper
    {
        /// <summary>
        /// 验证帐号密码
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static LoginResult Validate(string account, string password)
        {
            LoginResult loginResult = new LoginResult();

            Customer user = new BaseDAL<Customer>().GetModels(a => a.Account == account).FirstOrDefault();

            if (user == null)
            {
                loginResult.State = false;
                loginResult.Message = "用户名不存在";
            }
            else if (password != PasswordHelper.DESDecrypt(user.Password))
            {
                loginResult.State = false;
                loginResult.Message = "用户名或密码不正确";
            }
            else
            {
                loginResult.State = true;
                loginResult.Message = "登录成功";
                loginResult.UserDisplayName = user.DisplayName;
                loginResult.UserAccount = user.Account;
            }

            return loginResult;
        }

        /// <summary>
        /// 尝试登陆
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static LoginResult TryLogin(string account, string password)
        {
            LoginResult loginResult = Validate(account,password);

            return loginResult;
        }

    }
}
