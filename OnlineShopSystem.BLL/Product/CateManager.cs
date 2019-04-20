using Newtonsoft.Json.Linq;
using OnlineShopSystem.DAL;
using OnlineShopSystem.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Product
{
    public class CateManager
    {
        public static JObject GetList()
        {
            JObject result = new JObject();

            var list = new BaseDAL<BaseCategory>().GetAllModels().ToList();

            result["code"] = 0;
            result["msg"] = "";
            result["count"] = list.Count;
            result["data"] = JArray.FromObject(list);

            return result;
        }
    }
}
