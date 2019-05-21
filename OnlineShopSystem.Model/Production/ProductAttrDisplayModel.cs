using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    public class ProductAttrDisplayModel : ProductAttr
    {
        public List<ProductAttrValue> Values { get; set; }
    }
}
