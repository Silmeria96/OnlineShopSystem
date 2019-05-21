using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Search
{
    /// <summary>
    /// 查询分页帮助类
    /// </summary>
    public class PagnationHelper<T>
    {
        /// <summary>
        /// 分页方法
        /// </summary>
        /// <param name="list"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public List<T> Pagnation(List<T> list, int pageIndex, int pageSize, out int total)
        {
            total = list.Count;
            return list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
