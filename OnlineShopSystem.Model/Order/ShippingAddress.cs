using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Order
{
    /// <summary>
    /// 收获地址
    /// </summary>
    public class ShippingAddress
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverPhone { get; set; }

        public string ReceiverLocationID { get; set; }

        public string ReceiverAddress { get; set; }

        public string ReceiverZip { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
