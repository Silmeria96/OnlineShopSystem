using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.User
{
    /// <summary>
    /// 用户商品浏览记录
    /// </summary>
    public class CustomerBrowserHistory
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="帐号")]
        public string Account { get; set; }

        [Display(Name = "商品ID")]
        public int ProductID { get; set; }

        [Display(Name = "最新浏览时间")]
        public DateTime? LastestBrowserDate { get; set; }

        [Display(Name = "浏览次数")]
        public int BrowserTimes { get; set; }
    }
}
