using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品属性
    /// </summary>
    public class ProductAttr
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name="商品ID")]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "属性名称")]
        public string Name { get; set; }
    }
}
