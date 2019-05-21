using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.SellerArea
{
    /// <summary>
    /// 卖家店铺表
    /// </summary>
    public class SellerShop
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        [Display(Name="店铺名称")]
        public string Name { get; set; }

    }
}
