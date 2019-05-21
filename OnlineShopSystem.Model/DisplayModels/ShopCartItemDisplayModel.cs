using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.DisplayModels
{
    /// <summary>
    /// 购物车展示模型类
    /// </summary>
    public class ShopCartItemDisplayModel
    {
        public string ThumbImgUrl { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }
    }
}
