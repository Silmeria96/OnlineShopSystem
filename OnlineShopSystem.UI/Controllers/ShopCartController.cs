using Newtonsoft.Json.Linq;
using OnlineShopSystem.BLL.ShopCart;
using OnlineShopSystem.BLL.User;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.DisplayModels;
using OnlineShopSystem.Model.Order;
using OnlineShopSystem.Model.Production;
using OnlineShopSystem.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopSystem.UI.Controllers
{
    /// <summary>
    /// 购物车控制器
    /// </summary>
    public class ShopCartController : Controller
    {
        private SysContext db = new SysContext();

        /// <summary>
        /// 购物车首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 购物车首页 - 获取购物车列表
        /// </summary>
        /// <returns></returns>
        public JObject GetList()
        {
            int UID = (int)Session["UID"];
            List<ShopCartItem> cart_list = ShopCartHelper.GetUserShopCartList(db, UID);
            List<ShopCartItemDisplayModel> cart_display_list = new List<ShopCartItemDisplayModel>();

            foreach(var item in cart_list)
            {
                Product product = db.Products.Find(item.ProductID);
                ShopCartItemDisplayModel model = new ShopCartItemDisplayModel();
                model.ThumbImgUrl = product.ThumbImgUrl;
                model.Name = product.Name;
                model.Price = product.Price;
                model.Amount = item.Amount;
                cart_display_list.Add(model);
            }

            JObject rv = new JObject();
            rv["code"] = 0;
            rv["data"] = JArray.FromObject(cart_display_list);

            return rv;
        }

        /// <summary>
        /// 尝试添加到购物车
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public bool TryAddToCart(AddToCartModel model)
        {
            bool result = ShopCartHelper.TrtAddToCart(db, model);
            return result;
        }

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public ActionResult AddToCart(bool result)
        {
            if (result)
            {
                ViewBag.Message = "商品已成功加入购物车！";
                return View();
            }

            ViewBag.Message = "商品加入购物车失败！";
            return View();
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
        /// 订单确认后下单
        /// </summary>
        /// <param name="confirm"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult OrderConfirm(string confirm)
        {
            return View();
        }

    }
}