using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品分类关系表
    /// </summary>
    public class ProductCateRelation
    {
        public int ID { get; set; }

        [Display(Name="商品ID")]
        public int ProductID { get; set; }

        [Display(Name="分类ID")]
        public int CategoryID { get; set; }
    }
}
