using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 用户个人中心控制器
    /// </summary>
    [Authorize]
    public class UserCenterController : Controller
    {
        /// <summary>
        /// “个人中心”页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            // 显示用户昵称
            var userDisplayName = @Session["UserDisplayName"];
            if (userDisplayName != null)
            {
                ViewBag.UserDisplayName = userDisplayName.ToString();  
            }

            return View();
        }

        /// <summary>
        /// 我的评价 - 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult MyCommentsPartial()
        {
            return PartialView();
        }

        /// <summary>
        /// 常购商品 - 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult MyMostBuyedProductsPartial()
        {
            return PartialView();
        }

        /// <summary>
        /// 关注的商品 - 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult MyFocusProductsPartial()
        {
            return PartialView();
        }

        /// <summary>
        /// 关注的店铺 - 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult MyFocusShopsPartial()
        {
            return PartialView();
        }

        /// <summary>
        /// 个人信息 - 分部视图
        /// </summary>
        /// <returns></returns>
        public ActionResult MyInfoPatrial()
        {
            return PartialView("_MyInfoPatrial");
        }

        /// <summary>
        /// 收货地址 - 分部视图
        /// </summary>
        /// <returns></returns>
        public ActionResult MyAdressPatrial()
        {
            return PartialView("_MyAddressPatrial");
        }

    }
}