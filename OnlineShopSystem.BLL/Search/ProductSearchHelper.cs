using OnlineShopSystem.Model.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopSystem.Model;
using System.Reflection;
using OnlineShopSystem.BLL.Reflection;
using System.Collections;

namespace OnlineShopSystem.BLL.Search
{
    /// <summary>
    /// 商品搜索帮助类
    /// </summary>
    public class ProductSearchHelper : ISearchHelper<Product>
    {
        /// <summary>
        /// 根据属性和属性值搜索
        /// </summary>
        /// <param name="attrName"></param>
        /// <param name="keyword"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public List<Product> SearchByAttr(string attrName, string keyword, SysContext db)
        {
            Hashtable ht = new Hashtable();
            ht.Add(attrName, keyword);

            var search_result = ReflectionHelper<Product>.PageSortList(db.Products.ToList(), ht);

            return search_result;
        }

        /// <summary>
        /// 根据ID搜索
        /// </summary>
        /// <param name="id"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public Product SearchById(int id, SysContext db)
        {
            return db.Products.Find(id);
        }

        /// <summary>
        /// 根据关键词搜索
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public List<Product> SearchByKey(string keyword, SysContext db)
        {
            return db.Products.Where(p => p.Name.Contains(keyword)).ToList();
        }

        ///// <summary>
        ///// 根据实体类搜索
        ///// </summary>
        ///// <param name="t"></param>
        ///// <param name="db"></param>
        ///// <returns></returns>
        //public List<Product> SearchSimilar(Product t, SysContext db)
        //{
        //    int cate_id = db.Products.Find(t);

        //    return db.Products.Where(p => p.CateID == cate_id).ToList();
        //}
    }
}
