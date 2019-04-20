using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Product
{
    /// <summary>
    /// 货物分类属性值
    /// </summary>
    public class BaseCateAttrValue
    {
        [Key]
        public int ID { get; set; }


        [Display(Name = "分类ID")]
        public int CateID { get; set; }


        [Display(Name = "分类属性ID")]
        public int ProductAttrID { get; set; }


        [Display(Name = "属性值")]
        public string Value { get; set; }
    }
}
