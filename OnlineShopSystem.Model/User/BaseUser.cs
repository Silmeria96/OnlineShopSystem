using System;
using System.Collections.Generic;
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
        [MaxLength(16, ErrorMessage = "用户名不能超过16位字符")]
        public string Account { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "密码长度溢出")]
        public string Password { get; set; }

        [Display(Name = "昵称")]
        public string DisplayName { get; set; }

        public string Token { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
