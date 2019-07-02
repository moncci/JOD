using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace JOD.Utils
{
    /// <summary>
    /// xml转换器
    /// </summary>
    public static class XmlConverter
    {

        /// <summary>
        /// xml序列化
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="obj">被序列化的对象</param>
        /// <returns>xml</returns>
        public static string Serialize<T>(this T obj)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                var settings = new XmlWriterSettings { Encoding = Encoding.UTF8, Indent = true };

                using (var xmlWriter = XmlWriter.Create(ms, settings))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    var namespaces = new XmlSerializerNamespaces();

                    xmlWriter.WriteStartDocument();
                    //xmlWriter.WriteDocType("Field1", null, "someObject.dtd", null);
                    namespaces.Add(string.Empty, string.Empty);
                    serializer.Serialize(xmlWriter, obj, namespaces);
                }

                string xml = System.Text.Encoding.UTF8.GetString(ms.ToArray());
                return xml;
            }
        }

        /// <summary>
        /// xml反序列化
        /// </summary>
        /// <typeparam name="T">对象</typeparam>
        /// <param name="xml">xml</param>
        /// <returns>对象</returns>
        public static T Deserialize<T>(this string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xml);
            T result = (T)(serializer.Deserialize(reader));
            reader.Close();
            reader.Dispose();

            return result;
        }
    }
}
