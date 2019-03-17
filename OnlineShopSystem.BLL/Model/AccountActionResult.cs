using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Model
{
    public class AccountActionResult
    {
        // 是否成功
        public bool State { get; set; }

        // 结果信息
        public string Message { get; set; }

        // 用户帐号
        public string UserAccount { get; set; }

        // 用户名
        public string UserDisplayName { get; set; }
    }
}
