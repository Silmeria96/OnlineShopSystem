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
    /// 管理员账户
    /// </summary>
    [Table("Administrator")]
    public class Administrator : BaseUser
    {
        [Display(Name = "管理员级别")]
        public int AdminLevel { get; set; }
    }
}
