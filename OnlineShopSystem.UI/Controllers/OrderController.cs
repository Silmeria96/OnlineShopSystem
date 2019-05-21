using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    public class OrderController : Controller
    {
        /// <summary>
        /// 订单首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 我的订单 - 分部视图
        /// </summary>
        /// <returns></returns>
        public PartialViewResult MyOrderListPartial()
        {
            return PartialView();
        }

        /// <summary>
        /// 订单确认页面
        /// </summary>
        /// <returns></returns>
        public ActionResult OrderConfirm()
        {
            return View();
        }

        /// <summary>
        /// 创建评论
        /// </summary>
        /// <returns></returns>
        public ActionResult WriteComment()
        {
            return View();
        }

    }
}