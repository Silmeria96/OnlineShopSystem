using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Product
{
    /// <summary>
    /// 基础产品表
    /// </summary>
    public class BaseProduct
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "种类类ID")]
        public int CateID { get; set; }

        [Display(Name = "名称")]
        public string Name { get; set; }

        [Display(Name = "副标题")]
        public string SubTitle { get; set; }

        public string Detail { get; set; }

        [Display(Name = "缩略图URL")]
        public string ThumbImgUrl { get; set; }

        [Display(Name = "价格")]
        public double Price { get; set; }

        [Display(Name = "库存量")]
        public int Stock { get; set; }

        [Display(Name = "状态")]
        public int Status { get; set; }

        [Display(Name = "创建时间")]
        public DateTime? CreateTime { get; set; }

        [Display(Name = "更新时间")]
        public DateTime? UpdateTime { get; set; }
    }
}
