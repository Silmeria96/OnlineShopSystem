using OnlineShopSystem.Model.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.DAL.Production
{
    public class ProductAttrDAL : BaseDAL<ProductAttr>
    {
        /// <summary>
        /// 根据商品ID，获取所有商品属性
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<ProductAttr> GetAttrsByProductID(int productId)
        {
            // 查询商品的所有属性
            List<ProductAttr> product_attrs = (from s in this.dbContext.Set<ProductAttr>()
                                               where s.ProductID == productId
                                               select s).ToList();

            return product_attrs;
        }

        /// <summary>
        /// 根据商品ID，获取所有商品属性及属性值
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public List<ProductAttrDisplayModel> GetAttrModelsByProductID(int productId)
        {
            // 查询结果
            List<ProductAttrDisplayModel> attr_models = new List<ProductAttrDisplayModel>();

            // 1. 获取商品所有属性
            List<ProductAttr> attrs = this.GetAttrsByProductID(productId);

            // 2. 商品属性转换为展示模型
            foreach(var attr in attrs)
            {
                ProductAttrDisplayModel display_model = new ProductAttrDisplayModel();
                display_model.ID = attr.ID;
                display_model.ProductID = attr.ProductID;
                display_model.Name = attr.Name;
                display_model.Values = dbContext.Set<ProductAttrValue>().Where(a => a.ProductID == productId && a.ProductAttrID == attr.ID).ToList();

                attr_models.Add(display_model);
            }

            return attr_models;
        }

    }
}
