using Newtonsoft.Json.Linq;
using OnlineShopSystem.DAL.Account;
using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlineShopSystem.UI.Controllers
{
    public class MngCustomerApiController : ApiController
    {
        private SysContext db = new SysContext();
        private CustomerDAL dal = new CustomerDAL();

        // 获取全部数据
        public JObject GetAll()
        {
            JObject rv = new JObject();

            try
            {
                var result = dal.GetAllModels();

                rv["code"] = 0;
                rv["msg"] = "加载数据成功！";
                rv["count"] = result.Count();
                rv["data"] = JArray.FromObject(result);
            }
            catch (Exception e)
            {
                rv["code"] = 1;
                rv["msg"] = e.Message;
                rv["count"] = 0;
            }

            return rv;
        }

    }
}
