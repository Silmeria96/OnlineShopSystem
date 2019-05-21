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
    public static class CustomerRegisterHelper
    {
        /// <summary>
        /// 检查用户名是否已存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool CheckAccount(string account)
        {
            // 查找该用户是否存在
            Customer user = new BaseDAL<Customer>().GetModels(a => a.Account == account).FirstOrDefault();

            // 返回结果
            if (user == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 尝试注册用户
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static RegisterResult TryRegister(string account, string password)
        {
            RegisterResult result = new RegisterResult();

            // 检测用户名是否存在
            if (CheckAccount(account))
            {
                result.State = false;
                result.Message = "该用户名已存在！";

                return result;
            }

            // 新建一个用户
            Customer newUser = new Customer();
            newUser.Account = account;
            newUser.Password = PasswordHelper.DESEncrypt(password);

            // 添加该用户
            var userDAL = new BaseDAL<Customer>();
            userDAL.Add(newUser);

            // 根据添加结果返回信息
            var saveResult = userDAL.SaveChanges();

            if (saveResult)
            {
                result.State = true;
                result.Message = "注册成功！";
                result.UserAccount = newUser.Account;
                result.UserDisplayName = newUser.DisplayName;
            }
            else
            {
                result.State = false;
                result.Message = "注册用户时发生了未知错误！";
            }

            return result;
        }

    }
}
