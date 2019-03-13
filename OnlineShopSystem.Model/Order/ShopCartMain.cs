using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 购物车主表
    /// </summary>
    public class ShopCartMain
    {
        [Key]
        public int CartID { get; set; }

        [Display(Name = "用户ID")]
        public int UserID { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "更改时间")]
        public DateTime? UpdateTime { get; set; }
    }
}
