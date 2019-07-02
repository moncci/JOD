using JOD.Attributes;
using JOD.Writer.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace JOD.Utils
{
    /// <summary>
    /// 引号转换器
    /// </summary>
    public static class ConlonConverter
    {
        /// <summary>
        /// 转换为xml格式
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static string ToXmlConlon<T>(this string xml)
            where T : WriterKeyword, new()
        {
            string newxml = xml;

            T keyword = new T();
            Type t = typeof(T);
            //FieldInfo[] fields = t.GetFields();
            List<FieldInfo> fields = GetFiled(t);
            if (fields != null && fields.Count > 0)
            {
                foreach (FieldInfo p in fields)
                {
                    var keywordAttribute = p.GetCustomAttribute<XmlKeywordAttribute>();
                    if (keywordAttribute != null)
                    {
                        string xmlValue = keywordAttribute.XmlKey;
                        string objectValue = (string)p.GetValue(keyword);
                        newxml = newxml.Replace(objectValue, xmlValue);
                    }
                }
            }
            return newxml;
        }

        private static List<FieldInfo> GetFiled(Type t)
        {
            List<FieldInfo> fieldAll = new List<FieldInfo>();
            Type baseT = t.BaseType;
            if(baseT != typeof(Object))
            {
                List<FieldInfo> basefields = GetFiled(baseT);
                if(basefields != null && basefields.Count > 0)
                {
                    fieldAll.AddRange(basefields);
                }
            }
            FieldInfo[] fields = t.GetFields();
            if(fields !=  null && fields.Length > 0)
            {
                foreach (var item in fields)
                {
                    var m = fieldAll.Where(v => v.Name == item.Name).FirstOrDefault();
                    if(m == null)
                    {
                        fieldAll.Add(item);
                    }
                }
            }
            return fieldAll;
        }

        /// <summary>
        /// 转换为xml格式
        /// </summary>
        /// <param name="xml"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static string ToObjectConlon<T>(this string xml)
            where T : WriterKeyword, new()
        {
            string newxml = xml;

            T keyword = new T();
            Type t = typeof(T);
            FieldInfo[] fields = t.GetFields();

            if (fields != null)
            {
                foreach (FieldInfo p in fields)
                {
                    var keywordAttribute = p.GetCustomAttribute<XmlKeywordAttribute>();
                    if (keywordAttribute != null)
                    {
                        string xmlValue = keywordAttribute.XmlKey;
                        string objectValue = (string)p.GetValue(keyword);
                        newxml = newxml.Replace(xmlValue, objectValue);
                    }
                }
            }
            return newxml;
        }
    }
}
