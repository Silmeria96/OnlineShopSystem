using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopSystem.UI.Models
{
    /// <summary>
    /// 用户注册模型类
    /// </summary>
    public class CustomerRegisterModel
    {
        public string Account { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}