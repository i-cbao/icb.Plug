using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LBS.Amap.api.Common
{
    //[XmlRoot(Namespace = "", IsNullable = false, ElementName = "Response")]
    public class XMLHelper<T> where T : class
    {
        //public static object Deserialize(Type type, string xml)
        //{
        //    try
        //    {
        //        using (StringReader sr = new StringReader(xml))
        //        {
        //            XmlSerializer xmldes = new XmlSerializer(type);
        //            return xmldes.Deserialize(sr);
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        return null;
        //    }
        //}
        /// <summary>
        /// 将XML字符串反序列化为对象
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="xml">XML</param>
        /// <returns name="T">对象</returns>
        public static T DeserializeToObject(string xml)
         { 
             XmlSerializer serializer = new XmlSerializer(typeof(T));
             StringReader reader = new StringReader(xml);
             T entity = (T) serializer.Deserialize(reader);
             reader.Close();
             return entity;
         } 
    }
}
