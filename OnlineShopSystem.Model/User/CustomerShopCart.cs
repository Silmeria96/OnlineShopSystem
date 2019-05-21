using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 用户购物车记录
    /// </summary>
    public class CustomerShopCart
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="用户帐号")]
        public string Account { get; set; }

        [Display(Name = "商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "数量")]
        public int Amount { get; set; }
    }
}
