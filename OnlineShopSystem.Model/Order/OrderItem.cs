using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 订单明细表
    /// </summary>
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }


        [Display(Name = "订单主表ID")]
        public int PID { get; set; }


        [Display(Name = "用户ID")]
        public int UserID { get; set; }


        [Display(Name = "商品ID")]
        public int ProductID { get; set; }


        [Display(Name = "商品单价")]
        public double CurrentUnitPrice { get; set; }


        [Display(Name = "商品数量")]
        public int Quantity { get; set; }


        [Display(Name = "总价")]
        public double TotalPrice { get; set; }


        [Display(Name = "创建日期")]
        public DateTime? CreateTime { get; set; }


        [Display(Name = "更新日期")]
        public DateTime? UpdateTime { get; set; }
    }
}
