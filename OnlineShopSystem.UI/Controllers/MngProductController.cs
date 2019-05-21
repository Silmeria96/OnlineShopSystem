using Newtonsoft.Json.Linq;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.Production;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 商品管理控制器
    /// </summary>
    public class MngProductController : Controller
    {
        private SysContext db = new SysContext();

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 新建页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]  // 注意：取消了标记验证，用于提交商品富文本描述
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductDisplayModel model)
        {
            return View();
        }

        /// <summary>
        /// 编辑页面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int? id)
        {
            return View(db.Products.Find(id));
        }

        /// <summary>
        /// 保存编辑
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]  // 注意：取消了标记验证，用于提交商品富文本描述
        [ValidateAntiForgeryToken]
        public JObject Edit(Product product)
        {
            JObject rv = new JObject();

            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();

                rv["code"] = 0;
                rv["msg"] = "保存成功！";
                return rv;
            }

            rv["code"] = 1;
            rv["msg"] = "保存失败！";

            return rv;
        }

    }
}