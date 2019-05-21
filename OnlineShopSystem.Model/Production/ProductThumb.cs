using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品缩略图
    /// </summary>
    public class ProductThumb
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "缩略图Url")]
        public string ImageUrl { get; set; }
    }
}
