using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Production
{
    /// <summary>
    /// 商品评价
    /// </summary>
    public class ProductComment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Display(Name="创建日期")]
        public DateTime? CreateDate { get; set; }

        [Display(Name = "创建人")]
        public string CreateUserAccount { get; set; }

        [Display(Name = "评价等级")]
        public int Level { get; set; }

        [Required]
        [Display(Name = "评价内容")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "评论点赞量")]
        public int LikeNum { get; set; }

    }
}
