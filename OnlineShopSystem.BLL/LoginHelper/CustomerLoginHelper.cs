using OnlineShopSystem.DAL;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.LoginService
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
        public static bool Validate(string account, string password)
        {
            Customer user = new BaseDAL<Customer>().GetModels(a => a.Account == account).FirstOrDefault();

            if (user != null && password == PasswordHelper.DESDecrypt(user.Password))
                return true;
            else
                return false;
        }

    }
}
