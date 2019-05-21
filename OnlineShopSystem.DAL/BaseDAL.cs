using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.DAL
{
    /// <summary>
    /// DAL基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class BaseDAL<T> where T : class, new()
    {
        protected DbContext dbContext = DBHelper.Create();

        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="t"></param>
        public void Add(T t)
        {
            dbContext.Set<T>().Add(t);
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="t"></param>
        public void Delete(T t)
        {
            dbContext.Set<T>().Remove(t);
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="t"></param>
        public void Update(T t)
        {
            dbContext.Set<T>().AddOrUpdate(t);
        }

        /// <summary>
        /// 根据ID查找实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetModelById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        /// <summary>
        /// 获取所有实体集合
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAllModels()
        {
            return dbContext.Set<T>();
        }

        /// <summary>
        /// 根据条件获取实体集合
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda)
        {
            return dbContext.Set<T>().Where(whereLambda);
        }

        /// <summary>
        /// 获取分页实体集合
        /// </summary>
        /// <typeparam name="type">排序字段名</typeparam>
        /// <param name="pageSize">每页实体数量</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="OrderByLambda">排序表达式</param>
        /// <returns></returns>
        public IQueryable<T> GetPagedModels<type>(int pageSize, int pageIndex, Expression<Func<T, type>> OrderByLambda)
        {
            return dbContext.Set<T>().OrderBy(OrderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        /// <summary>
        /// 获取分页实体集合（带搜索、排序条件）
        /// </summary>
        /// <typeparam name="type"></typeparam>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="isAsc"></param>
        /// <param name="OrderByLambda"></param>
        /// <param name="WhereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> GetPagedModels<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> OrderByLambda, Expression<Func<T, bool>> WhereLambda)
        {
            if (isAsc)
            {
                return dbContext.Set<T>().Where(WhereLambda).OrderBy(OrderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                return dbContext.Set<T>().Where(WhereLambda).OrderByDescending(OrderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
        }

        /// <summary>
        /// 保存实体更改
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return dbContext.SaveChanges() > 0;
        }

    }

}
