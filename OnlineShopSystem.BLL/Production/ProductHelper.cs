using OnlineShopSystem.BLL.User;
using OnlineShopSystem.DAL.Production;
using OnlineShopSystem.Model;
using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.Production;
using OnlineShopSystem.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopSystem.BLL.Production
{
    /// <summary>
    /// 商品帮助类
    /// </summary>
    public class ProductHelper
    {
        private ProductDAL _productDAL;
        private ProductCateDAL _productCateDAL;
        private ProductAttrDAL _productAttrDAL;

        /// <summary>
        /// 获取商品DAL帮助类实例
        /// </summary>
        /// <returns></returns>
        private ProductDAL GetProductDAL()
        {
            if(_productDAL == null)
            {
                _productDAL = new ProductDAL();
            }

            return _productDAL;
        }

        /// <summary>
        /// 获取商品分类DAL帮助类实例
        /// </summary>
        /// <returns></returns>
        private ProductCateDAL GetProductCateDAL()
        {
            if (_productCateDAL == null)
            {
                _productCateDAL = new ProductCateDAL();
            }

            return _productCateDAL;
        }

        /// <summary>
        /// 获取商品属性DAL帮助类实例
        /// </summary>
        /// <returns></returns>
        private ProductAttrDAL GetProductAttrDAL()
        {
            if (_productAttrDAL == null)
            {
                _productAttrDAL = new ProductAttrDAL();
            }

            return _productAttrDAL;
        }



        /// <summary>
        /// 根据ID寻找商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetById(int id)
        {
            return GetProductDAL().GetModelById(id);
        }

        /// <summary>
        /// 获取分页商城列表
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<Product> GetPagedProductList(int pageSize, int pageIndex)
        {
            return GetProductDAL().GetPagedModels(pageSize, pageIndex, a => a.ProductID).ToList();
        }

        /// <summary>
        /// 根据ID获取商品展示模型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDisplayModel GetDisplayModelById(int id)
        {
            // 1. 获取商品基础信息
            Product model = GetProductDAL().GetModelById(id);

            // 2. 获取商品分类信息
            List<ProductCategory> Categories = GetProductCateDAL().GetCategoriesByProductID(id);

            // 3. 获取商品属性信息
            List<ProductAttrDisplayModel> Attributes = GetProductAttrDAL().GetAttrModelsByProductID(id);

            ProductDisplayModel result = new ProductDisplayModel();
            result.ProductID = model.ProductID;
            result.Name = model.Name;
            result.SubName = model.SubName;
            result.Describe = model.Describe;
            result.ThumbImgUrl = model.ThumbImgUrl;
            result.MainImgUrl = model.MainImgUrl;
            result.Price = model.Price;
            result.Stock = model.Stock;
            result.IsUsed = model.IsUsed;
            result.CreateTime = model.CreateTime;
            result.UpdateTime = model.UpdateTime;

            result.Categories = Categories;
            result.Attributes = Attributes;

            return result;
        }




        /// <summary>
        /// 添加商品浏览记录
        /// </summary>
        /// <param name="db"></param>
        /// <param name="account"></param>
        /// <param name="product_id"></param>
        /// <returns></returns>
        public bool AddBrowserHistory(SysContext db, string account, int product_id)
        {
            CustomerBrowserHistory browser_history = (from s in db.CustomerBrowserHistories
                                                      where s.Account == account && s.ProductID == product_id
                                                      select s).FirstOrDefault();

            if (browser_history != null)
            {
                browser_history.LastestBrowserDate = DateTime.Now;
                browser_history.BrowserTimes += 1;
            }
            else
            {
                CustomerBrowserHistory new_history = new CustomerBrowserHistory();
                new_history.Account = account;
                new_history.ProductID = product_id;
                new_history.LastestBrowserDate = DateTime.Now;
                new_history.BrowserTimes = 1;

                db.CustomerBrowserHistories.Add(new_history);
            }

            if (db.SaveChanges() > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据商品ID获取该商品总浏览量
        /// </summary>
        /// <returns></returns>
        public int GetBrowserCountById(SysContext db, int id)
        {
            return db.CustomerBrowserHistories.Where(a => a.ProductID == id).Count();
        }

        /// <summary>
        /// 根据商品ID获取评论
        /// </summary>
        /// <param name="db"></param>
        /// <param name="product_id"></param>
        /// <returns></returns>
        public List<ProductComment> GetCommentsById(SysContext db, int product_id)
        {
            return db.ProductComments.Where(a => a.ProductID == product_id).ToList();
        }

        /// <summary>
        /// 根据商品ID推荐同分类商品
        /// </summary>
        /// <param name="db"></param>
        /// <param name="product_id"></param>
        /// <returns></returns>
        public List<Product> GetSameCategoryRecommendList(SysContext db, int product_id)
        {
            // 查询该商品的分类
            List<ProductCateRelation> target_cate_relation = db.ProductCateRelations.Where(a => a.ProductID == product_id).ToList();

            // 查询该商品分类下的其它商品ID
            List<int> target_product_ids = (from s in db.ProductCateRelations
                                            where (s.ProductID != product_id)
                                            select s.ProductID).ToList();

            // 查询其它推荐商品（取5个）
            List<Product> target_products = (from s in db.Products
                                             where ((from t in target_product_ids
                                                     select t).Contains(s.ProductID))
                                             select s).Take(5).ToList();

            return target_products;
        }

    }
}
