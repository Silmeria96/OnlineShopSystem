using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Product
{
    /// <summary>
    /// 产品属性值表
    /// </summary>
    public class BaseProductAttrValue
    {
        [Key]
        public int ID { get; set; }

        public int CateID { get; set; }

        public int ProductAttrID { get; set; }

        public string Value { get; set; }
    }
}
