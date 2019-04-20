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


        [Display(Name = "序号")]
        public int OrderNo { get; set; }


        [Display(Name = "用户ID")]
        public int UserID { get; set; }


        [Display(Name = "应付金额")]
        public double Payment { get; set; }


        [Display(Name = "支付方式")]
        public int PaymentType { get; set; }


        [Display(Name = "是否已发货")]
        public double Postage { get; set; }


        [Display(Name = "是否启用")]
        public bool IsUsed { get; set; }


        [Display(Name = "支付时间")]
        [DataType(DataType.DateTime)]
        public DateTime? PaymentTime { get; set; }


        [Display(Name = "发货时间")]
        [DataType(DataType.DateTime)]
        public DateTime? SendTime { get; set; }


        [Display(Name = "完成时间")]
        [DataType(DataType.DateTime)]
        public DateTime? EndTime { get; set; }


        [Display(Name = "关闭时间")]
        [DataType(DataType.DateTime)]
        public DateTime? CloseTime { get; set; }


        [Display(Name = "创建日期")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateTime { get; set; }


        [Display(Name = "更新日期")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateTime { get; set; }
    }
}
