using Newtonsoft.Json.Linq;
using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 移动端APP - 商品API
    /// </summary>
    public class ProductApiController : ApiController
    {
        private SysContext db = new SysContext();

        public JObject GetAllGet()
        {
            var products = db.Products.ToList();

            JObject rv = new JObject();
            rv["total"] = products.Count;
            rv["children"] = JArray.FromObject(products);

            return rv;
        }

        [HttpPost]
        public JObject GetAllPost()
        {
            var products = db.Products.ToList();

            JObject rv = new JObject();
            rv["total"] = products.Count;
            rv["children"] = JArray.FromObject(products);

            return rv;
        }


    }

}
