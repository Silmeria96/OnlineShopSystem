using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.Model.Search
{
    /// <summary>
    /// 搜索关键字
    /// </summary>
    public class SearchKey
    {
        public int ID { get; set; }

        [Display(Name="关键字来源")]
        public int Source { get; set; }

        [Display(Name = "关键字内容")]
        public string Value { get; set; }

        [Display(Name = "搜索次数")]
        public int SearchTimes { get; set; }
    }
}
