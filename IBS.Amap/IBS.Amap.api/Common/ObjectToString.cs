using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.Common
{
    public static class ObjectToString
    {
        public static string EntityToString<T>(T t)
        {
            string tStr = string.Empty;
            if (t == null)
            {
                return tStr;
            }
            //获取所有属性
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return tStr;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(t, null);
                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    tStr += string.Format("{0}={1}&", name, value);
                }
                else
                {
                    EntityToString(value);
                }
            }
            return tStr;
        }


    }
}
