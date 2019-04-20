using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OnlineShopSystem.DAL;
using OnlineShopSystem.Model.User;
using OnlineShopSystem.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.User
{
    // 客户信息管理类

    public class CustomerManager
    {
        // 获取全部客户信息
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
        

        public static void AddCustomer(Customer customer)
        {
            var baseDAL = new BaseDAL<Customer>();

            customer.Password = PasswordHelper.DESEncrypt(customer.Password);

            baseDAL.Add(customer);
            baseDAL.SaveChanges();
        }


        public static Customer FindById(int? id)
        {
            Customer customer = new BaseDAL<Customer>().GetModels(a => a.UserID == id).FirstOrDefault();

            return customer;
        }

    }
}
