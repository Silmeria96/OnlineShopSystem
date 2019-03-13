using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OnlineShopSystem.UI.Util
{
    public class CommonFunc
    {
        /// <summary>
        /// 获取AppSettings中的配置信息
        /// </summary>
        /// <param name="key">配置项key</param>
        /// <returns></returns>
        public static string GetConfig(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("配置参数的key不能为空");

            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
                throw new ArgumentException(String.Format("key：{0}在AppSettings中不存在", key));

            string value = ConfigurationManager.AppSettings[key];

            return value;
        }
    }
}