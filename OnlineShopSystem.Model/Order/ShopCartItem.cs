using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 用户购物车信息
    /// </summary>
    public class ShopCartItem
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="用户ID")]
        public int UserID { get; set; }

        [Display(Name = "商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "商品数量")]
        public int Amount { get; set; }

        [Display(Name="添加日期")]
        public DateTime? CreateDate { get; set; }

    }
}
