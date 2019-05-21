using OnlineShopSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.DAL
{
    /// <summary>
    /// 数据上下文创建类
    /// </summary>
    public class DBHelper
    {
        /// <summary>
        /// 创建数据库上下文
        /// </summary>
        /// <returns></returns>
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext;

            if (dbContext == null)
            {
                dbContext = new SysContext();
                CallContext.SetData("DbContext", dbContext);
            }

            return dbContext;
        }

    }
}
