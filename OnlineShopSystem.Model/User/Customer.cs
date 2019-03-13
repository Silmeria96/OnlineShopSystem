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
        public int? Age { get; set; }

        public DateTime? Birthday { get; set; }

        public string Address { get; set; }
    }
}
