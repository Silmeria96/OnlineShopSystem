using OnlineShopSystem.Model.Category;
using OnlineShopSystem.Model.Order;
using OnlineShopSystem.Model.Product;
using OnlineShopSystem.Model.User;
using System.Data.Entity;

namespace OnlineShopSystem.Model
{
    public class SysContext : DbContext
    {
        public SysContext() : base("SysConnection")
        {
        }

        #region 用户账户

        public virtual DbSet<BaseUser> BaseUsers { get; set; }

        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Customer> Customers { get; set; }

        #endregion

        #region 产品相关

        public DbSet<BaseCategory> BaseCategories { get; set; }

        public DbSet<BaseProduct> BaseProducts { get; set; }

        public DbSet<BaseProductAttr> BaseProductAttrs { get; set; }

        public DbSet<BaseProductAttrValue> BaseProductAttrValues { get; set; }

        #endregion

        #region 订单相关

        public DbSet<ShopCartMain> ShopCarts { get; set; }

        public DbSet<ShopCartItem> ShopCartItems { get; set; }

        public DbSet<OrderMain> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        #endregion

    }
}
