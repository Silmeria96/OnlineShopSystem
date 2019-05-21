using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopSystem.BLL.Reflection
{
    /// <summary>
    /// 反射帮助类
    /// </summary>
    public static class ReflectionHelper<T>
    {
        /// <summary>
        /// 根据属性名获取属性值
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetValueByAttrName(T obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        /// <summary>
        /// 通过Linq表达式获取成员属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static Tuple<string, string> GetPropertyValue(T instance, Expression<Func<T, string>> expression)
        {
            MemberExpression memberExpression = expression.Body as MemberExpression;

            string propertyName = memberExpression.Member.Name;

            string attributeName = (memberExpression.Member.GetCustomAttributes(false)[0] as DescriptionAttribute).Description;

            var property = typeof(T).GetProperties().Where(l => l.Name == propertyName).First();

            return new Tuple<string, string>(attributeName, property.GetValue(instance).ToString());

        }

        public static List<T> PageSortList(List<T> listT, Hashtable ht)
        {
            string key = ht.Cast<DictionaryEntry>().FirstOrDefault().Key.ToString();
            string value = ht.Cast<DictionaryEntry>().FirstOrDefault().Value.ToString();
            string propertyValue = listT.First().GetType().GetProperty(key).GetValue(listT.First(), null).ToString();

            listT = listT.Where(m => m.GetType().GetProperty(key).GetValue(m, null).ToString().Contains(value)).ToList();

            return listT;
        }
    }
}
