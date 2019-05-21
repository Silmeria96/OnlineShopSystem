using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.SellerArea
{
    /// <summary>
    /// 卖家店铺商品关联表
    /// </summary>
    public class SellerShopProduct
    {
        [Key]
        public int ID { get; set; }

        public int SellerShopID { get; set; }  // 卖家店铺ID

        public int ProductID { get; set; }  // 商品ID
    }
}
