using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShopSystem.UI.Models
{
    public class CustomerLoginModel
    {
        [Required]
        [Display(Name = "帐号")]
        public string LoginAccount { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string LoginPassword { get; set; }
    }
}