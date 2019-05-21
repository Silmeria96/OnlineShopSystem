using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnlineShopSystem.DAL;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.User
{
    /// <summary>
    /// 客户信息管理类
    /// </summary>
    public class CustomerManager
    {
        /// <summary>
        /// 获取全部客户信息
        /// </summary>
        /// <returns></returns>
        public static JObject GetAllCustomers()
        {
            JObject result = new JObject();

            var customers = new BaseDAL<Customer>().GetAllModels().ToList();

            result["code"] = 0;
            result["msg"] = "";
            result["count"] = customers.Count;
            result["data"] = JArray.FromObject(customers);

            return result;
        }
        
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="customer"></param>
        public static void AddCustomer(Customer customer)
        {
            var baseDAL = new BaseDAL<Customer>();

            customer.Password = PasswordHelper.DESEncrypt(customer.Password);

            baseDAL.Add(customer);
            baseDAL.SaveChanges();
        }

        /// <summary>
        /// 根据用户id寻找用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer FindById(int? id)
        {
            Customer customer = new BaseDAL<Customer>().GetModels(a => a.UserID == id).FirstOrDefault();

            return customer;
        }

        /// <summary>
        /// 根据用户帐号寻找用户
        /// </summary>
        /// <param name="db"></param>
        /// <param name="account"></param>
        /// <returns></returns>
        public static Customer FindByAccount(SysContext db,string account)
        {
            return db.Customers.Where(u => u.Account == account).FirstOrDefault();
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="db"></param>
        /// <param name="account"></param>
        /// <param name="new_password"></param>
        /// <returns></returns>
        public bool ChangePassword(SysContext db, string account, string new_password)
        {
            Customer customer = CustomerManager.FindByAccount(db, account);

            if (customer != null)
            {
                customer.Password = PasswordHelper.MD5Encrypt16(new_password);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
