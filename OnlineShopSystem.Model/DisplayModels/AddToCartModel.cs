using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.DisplayModels
{
    /// <summary>
    /// 加入购物车数据模型
    /// </summary>
    public class AddToCartModel
    {
        [Display(Name = "用户ID")]
        public int UserID { get; set; }

        [Display(Name = "商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "商品属性JSON")]
        public string ProductAttrsJson { get; set; }

        [Display(Name = "商品数量")]
        public int Amount { get; set; }
    }
}
