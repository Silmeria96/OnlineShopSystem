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

        public int UserID { get; set; }

        public int OrderNo { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductThumbImgUrl { get; set; }

        public double CurrentUnitPrice { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
