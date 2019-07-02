using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Attributes
{
    /// <summary>
    /// xml属性关键词特性
    /// </summary>
    public class XmlKeywordAttribute : Attribute
    {
        public string XmlKey { get; set; }
        public XmlKeywordAttribute(string xmlkey)
        {
            XmlKey = xmlkey;
        }
    }
}
