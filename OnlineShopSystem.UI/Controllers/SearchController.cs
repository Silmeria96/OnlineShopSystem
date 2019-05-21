using OnlineShopSystem.BLL.Production;
using OnlineShopSystem.BLL.Search;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 商品搜索控制器
    /// </summary>
    public class SearchController : Controller
    {
        private SysContext db = new SysContext();

        /// <summary>
        ///  搜索结果首页
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Index(string keyword, int pageIndex = 1)
        {
            ProductSearchHelper searchHelper = new ProductSearchHelper();
            PagnationHelper<Product> pagnationHelper = new PagnationHelper<Product>();

            var total = 0;
            var result = searchHelper.SearchByKey(keyword, db);
            var result_paged = pagnationHelper.Pagnation(result, pageIndex, 20, out total);

            ViewBag.Total = total;
            ViewBag.SearchResult = result_paged;

            return View();
        }


        /// <summary>
        /// 商品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Detail(int? id)
        {
            ViewBag.Title = "化妆品";  // 网页标题
            ViewBag.UID = Session["UID"] == null ? 0 : (int)Session["UID"];
            
            if (id != null)
            {
                ProductHelper helper = new ProductHelper();

                // 添加一条该商品的浏览记录
                if (Session["UserAccount"] != null)
                {
                    string account = Session["UserAccount"].ToString();
                    helper.AddBrowserHistory(db, account, (int)id);
                }
                
                // 返回指定ID的商品实体
                ProductDisplayModel model = helper.GetDisplayModelById((int)id);

                ViewBag.LeftRecommendList = helper.GetSameCategoryRecommendList(db, (int)id);

                return View(model);
            }

            return View();
        }


        /// <summary>
        /// 商品评论分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult ProductCommentPartial(int? id)
        {
            if (id != null)
            {
                ProductHelper helper = new ProductHelper();

                ViewBag.Comments = helper.GetCommentsById(db, (int)id);  // 商品评论
            }

            return PartialView();
        }


    }
}