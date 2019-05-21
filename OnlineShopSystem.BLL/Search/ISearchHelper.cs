using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Search
{
    /// <summary>
    /// 搜索接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ISearchHelper<T>
    {
        /// <summary>
        /// 根据ID搜索
        /// </summary>
        /// <param name="id"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        T SearchById(int id, SysContext db);

        /// <summary>
        /// 根据关键字搜索
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        List<T> SearchByKey(string keyword, SysContext db);

        /// <summary>
        /// 根据属性值搜索
        /// </summary>
        /// <param name="attrName"></param>
        /// <param name="keyword"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        List<T> SearchByAttr(string attrName, string keyword, SysContext db);

        ///// <summary>
        ///// 根据实体搜索相似实体
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="db"></param>
        ///// <returns></returns>
        //List<T> SearchSimilar(T t, SysContext db);
    }
}
