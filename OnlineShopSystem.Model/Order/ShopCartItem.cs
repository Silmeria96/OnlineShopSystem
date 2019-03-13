using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 购物车明细表
    /// </summary>
    public class ShopCartItem
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "购物车ID")]
        public int CartID { get; set; }

        [Display(Name = "产品ID")]
        public int ProductID { get; set; }

        [Display(Name = "数量")]
        public int Quantity { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "更改时间")]
        public DateTime? UpdateTime { get; set; }
    }
}
