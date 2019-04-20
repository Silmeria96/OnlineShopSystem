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
        public int TID { get; set; }


        [Display(Name = "用户ID")]
        public int UserID { get; set; }


        [Display(Name = "明细序号")]
        public int OrderNo { get; set; }


        [Display(Name = "产品ID")]
        public int ProductID { get; set; }


        [Display(Name = "产品名称")]
        public string ProductName { get; set; }


        [Display(Name = "产品图片")]
        public string ProductThumbImgUrl { get; set; }


        [Display(Name = "产品单价")]
        public double CurrentUnitPrice { get; set; }


        [Display(Name = "产品数量")]
        public int Quantity { get; set; }


        [Display(Name = "总价")]
        public double TotalPrice { get; set; }


        [Display(Name = "创建日期")]
        public DateTime? CreateTime { get; set; }


        [Display(Name = "更新日期")]
        public DateTime? UpdateTime { get; set; }
    }
}
