using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 网站用户基类
    /// </summary>
    public abstract class BaseUser
    {
        [Key]
        public int UserID { get; set; }


        [Required]
        [Display(Name = "帐号")]
        [MaxLength(16, ErrorMessage = "用户名不能超过16位字符")]
        public string Account { get; set; }


        [Required]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "密码长度溢出")]
        public string Password { get; set; }


        [Display(Name = "昵称")]
        [DefaultValue("小白")]
        public string DisplayName { get; set; }


        [Display(Name = "安全令牌")]
        [ScaffoldColumn(false)]
        public string Token { get; set; }


        [ReadOnly(true)]
        [Display(Name = "创建日期")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateTime { get; set; }


        [ReadOnly(true)]
        [Display(Name = "最近活跃日期")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateTime { get; set; }


        [ReadOnly(true)]
        [Display(Name = "是否在线")]
        [DefaultValue(false)]
        public bool IsOnline { get; set; }
    }
}
