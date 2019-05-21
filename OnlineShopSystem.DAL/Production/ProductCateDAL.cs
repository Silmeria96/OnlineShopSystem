using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.DAL.Production
{
    public class ProductCateDAL : BaseDAL<ProductCategory>
    {
        /// <summary>
        /// 根据商品ID，获取所有商品分类
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<ProductCategory> GetCategoriesByProductID(int productId)
        {
            // 查询商品的所有分类ID
            List<int> product_cate_relations = (from s in this.dbContext.Set<ProductCateRelation>()
                                                where s.ProductID == productId
                                                select s.CategoryID).ToList();
            // 查询商品的所有分类
            List<ProductCategory> categories = (from s in this.dbContext.Set<ProductCategory>()
                                                where product_cate_relations.Contains(s.CateID)
                                                select s).ToList();

            return categories;
        }

    }
}
