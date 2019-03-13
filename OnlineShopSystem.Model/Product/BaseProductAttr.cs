using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Product
{
    /// <summary>
    /// 产品属性表
    /// </summary>
    public class BaseProductAttr
    {
        [Key]
        public int ID { get; set; }

        public int CateID { get; set; }

        public string AttrName { get; set; }
    }
}
