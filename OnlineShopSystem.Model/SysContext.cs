using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.Order;
using OnlineShopSystem.Model.Production;
using OnlineShopSystem.Model.SellerArea;
using OnlineShopSystem.Model.User;
using System.Data.Entity;

namespace OnlineShopSystem.Model
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    public class SysContext : DbContext
    {
        public SysContext() : base("SysConnection")
        {
        }

        #region 用户账户

        public virtual DbSet<BaseUser> BaseUsers { get; set; }  // 基础用户

        public DbSet<Administrator> Administrators { get; set; }  // 管理员

        public DbSet<Customer> Customers { get; set; }  // 买家

        public DbSet<Seller> Sellers { get; set; }  // 卖家

        public DbSet<CustomerBrowserHistory> CustomerBrowserHistories { get; set; }  // 用户商品浏览记录

        public DbSet<CustomerCollection> CustomerCollections { get; set; }  // 用户收藏夹

        public DbSet<CustomerShopCart> CustomerShopCarts { get; set; }  // 用户购物车

        public DbSet<CustomerCommentToProduct> CustomerCommentToProducts { get; set; }  // 用户商品评论

        #endregion

        #region 商品相关

        public DbSet<Product> Products { get; set; }  // 商品

        public DbSet<ProductThumb> ProductThumbs { get; set; }  // 商品缩略图

        public DbSet<ProductCategory> ProductCategories { get; set; }  // 商品分类

        public DbSet<ProductCateRelation> ProductCateRelations { get; set; }  // 商品&商品分类关系

        public DbSet<ProductAttr> ProductAttrs { get; set; }  // 商品属性

        public DbSet<ProductAttrValue> ProductAttrValues { get; set; }  // 商品属性值

        public DbSet<ProductComment> ProductComments { get; set; }  // 商品评论

        #endregion

        #region 卖家相关

        public DbSet<SellerShop> SellerShops { get; set; }  // 卖家店铺

        public DbSet<SellerShopProduct> SellerShopProducts { get; set; }  // 卖家店铺商品明细

        #endregion

        #region 订单相关

        public DbSet<ShopCartItem> ShopCartItems { get; set; }  // 购物车

        public DbSet<OrderMain> Orders { get; set; }  // 订单

        public DbSet<OrderItem> OrderItems { get; set; }  // 订单明细

        #endregion

    }
}
