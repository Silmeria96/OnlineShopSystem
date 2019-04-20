using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Product
{
    /// <summary>
    /// 货物分类属性
    /// </summary>
    public class BaseCateAttr
    {
        [Key]
        public int ID { get; set; }


        [Display(Name = "分类ID")]
        public int CateID { get; set; }


        [Display(Name = "属性名称")]
        public string AttrName { get; set; }
    }
}
