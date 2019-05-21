using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 商品控制器
    /// </summary>
    public class ProductController : Controller
    {
        private SysContext db = new SysContext();

        /// <summary>
        /// 分部视图 - 商品介绍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PartialViewResult ProductIntroductionPartial(int? productId)
        {
            if(productId == null)
            {
                return PartialView("~/Views/Shared/_ErrorLayout.cshtml");
            }

            var product = db.Products.Find(productId);

            return PartialView(product);
        }

        /// <summary>
        /// 分部视图 - 商品规格
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PartialViewResult ProductSizePartial(int? productId)
        {
            // 在此处查询指定商品，显示介绍中存储的HTML富文本

            return PartialView();
        }

        /// <summary>
        /// 分部视图 - 商品评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PartialViewResult ProductCommentsPartial(int? productId)
        {
            // 在此处查询指定商品，显示介绍中存储的HTML富文本

            return PartialView();
        }

    }
}