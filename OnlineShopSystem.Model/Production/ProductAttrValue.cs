using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品属性值
    /// </summary>
    public class ProductAttrValue
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "商品属性ID")]
        public int ProductAttrID { get; set; }

        [Display(Name = "商品属性值")]
        public string Value { get; set; }

        [Display(Name = "商品属性值缩略图")]
        public string ThumbImgUrl { get; set; }

        [Display(Name = "附加金额")]
        public double ExtraPrice { get; set; }  // 商品选择一个不同的属性后，会对商品单价产生影响

    }
}
