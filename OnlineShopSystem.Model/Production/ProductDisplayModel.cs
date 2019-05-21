using OnlineShopSystem.Model.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品展示模型
    /// </summary>
    public class ProductDisplayModel : Product
    {
        // 商品所属分类
        public List<ProductCategory> Categories { get; set; }

        // 商品拥有的属性
        public List<ProductAttrDisplayModel> Attributes { get; set; }
    }
}
