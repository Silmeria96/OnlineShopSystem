using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 订单主表
    /// </summary>
    public class OrderMain
    {
        [Key]
        public int ID { get; set; }

        public int OrderNo { get; set; }

        public int UserID { get; set; }

        public double Payment { get; set; }

        public int PaymentType { get; set; }

        public double Postage { get; set; }

        public int Status { get; set; }

        public DateTime? PaymentTime { get; set; }

        public DateTime? SendTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? CloseTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
