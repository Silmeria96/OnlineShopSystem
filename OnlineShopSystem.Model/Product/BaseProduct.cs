using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        [Display(Name = "二级名称")]
        public string SubTitle { get; set; }


        [Display(Name = "详细描述")]
        [DataType(DataType.MultilineText)]
        public string Detail { get; set; }


        [Display(Name = "缩略图URL")]
        public string ThumbImgUrl { get; set; }


        [Display(Name = "价格")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }


        [Display(Name = "库存量")]
        public int Stock { get; set; }


        [Display(Name = "启用状态")]
        public bool IsUsed { get; set; }


        [ReadOnly(true)]
        [ScaffoldColumn(false)]
        [Display(Name = "创建时间")]
        [DataType(DataType.DateTime)]
        public DateTime? CreateTime { get; set; }


        [ReadOnly(true)]
        [ScaffoldColumn(false)]
        [Display(Name = "更新时间")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdateTime { get; set; }
    }

}
