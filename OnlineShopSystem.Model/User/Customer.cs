using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 客户账户
    /// </summary>
    [Table("Customer")]
    public class Customer : BaseUser
    {
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }


        [Display(Name = "地址")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }


        [Display(Name = "电话号码")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
