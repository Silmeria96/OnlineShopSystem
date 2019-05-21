using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 用户收藏夹
    /// </summary>
    public class CustomerCollection
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "用户帐号")]
        public string Account { get; set; }

        [Display(Name="收藏类型")]
        public string TypeCode { get; set; }

        [Display(Name = "收藏目标ID")]
        public int ItemID { get; set; }
    }
}
