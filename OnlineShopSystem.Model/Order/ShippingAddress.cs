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


        [Display(Name = "收货人ID")]
        public int UserID { get; set; }


        [Display(Name = "收货人姓名")]
        public string ReceiverName { get; set; }


        [Display(Name = "收货人电话")]
        public string ReceiverPhone { get; set; }


        [Display(Name = "收货地区ID")]
        public string ReceiverLocationID { get; set; }


        [Display(Name = "序号")]
        public string ReceiverAddress { get; set; }


        [Display(Name = "序号")]
        public string ReceiverZip { get; set; }


        [Display(Name = "创建日期")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateTime { get; set; }


        [Display(Name = "更新日期")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateTime { get; set; }
    }
}
