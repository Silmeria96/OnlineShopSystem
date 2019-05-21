using Newtonsoft.Json.Linq;
using OnlineShopSystem.DAL;
using OnlineShopSystem.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Production
{
    /// <summary>
    /// 商品分类帮助类
    /// </summary>
    public class ProductCategoryHelper
    {
        /// <summary>
        /// 获取首页分类列表
        /// </summary>
        /// <returns></returns>
        public static JObject GetCateListForHome()
        {
            JObject rv = new JObject();

            return rv;
        }

        /// <summary>
        /// 获取全部分类
        /// </summary>
        /// <returns></returns>
        public static JObject GetList()
        {
            JObject result = new JObject();

            var list = new BaseDAL<ProductCategory>().GetAllModels().ToList();

            result["code"] = 0;
            result["msg"] = "";
            result["count"] = list.Count;
            result["data"] = JArray.FromObject(list);

            return result;
        }
    }
}
