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


        [Display(Name = "父级分类ID")]
        public int? PID { get; set; }


        [Display(Name = "序号")]
        public int? OrderID { get; set; }


        [Display(Name = "分类名称")]
        public string CateName { get; set; }


        [Display(Name = "启用状态")]
        public bool IsUsed { get; set; }


        [Display(Name = "创建日期")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateTime { get; set; }


        [Display(Name = "更新日期")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateTime { get; set; }
    }
}
