using OnlineShopSystem.Model;
using OnlineShopSystem.Model.DisplayModels;
using OnlineShopSystem.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.ShopCart
{
    /// <summary>
    /// 购物车帮助类
    /// </summary>
    public static class ShopCartHelper
    {
        /// <summary>
        /// 获取用户购物车列表
        /// </summary>
        /// <param name="db"></param>
        /// <param name="uid"></param>
        /// <returns></returns>
        public static List<ShopCartItem> GetUserShopCartList(SysContext db, int uid)
        {
            return db.ShopCartItems.Where(i => i.UserID == uid).ToList();
        }

        /// <summary>
        /// 尝试加入购物车
        /// </summary>
        /// <param name="db"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool TrtAddToCart(SysContext db, AddToCartModel model)
        {
            ShopCartItem shop_cart_item = new ShopCartItem();
            shop_cart_item.UserID = model.UserID;
            shop_cart_item.ProductID = model.ProductID;
            shop_cart_item.CreateDate = DateTime.Now;
            shop_cart_item.Amount = model.Amount;
            db.ShopCartItems.Add(shop_cart_item);

            if (db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
