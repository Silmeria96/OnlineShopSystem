using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Category
{
    /// <summary>
    /// 货物分类基类
    /// </summary>
    public class BaseCategory
    {
        [Key]
        public int CateID { get; set; }

        public int? PID { get; set; }

        public int? OrderID { get; set; }

        public string CateName { get; set; }

        public bool Status { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
