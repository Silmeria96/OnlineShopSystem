using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 用户商品评论
    /// </summary>
    public class CustomerCommentToProduct
    {
        public int ID { get; set; }

        public string Account { get; set; }

        public int ProductID { get; set; }

        public int CommentID { get; set; }
    }
}
