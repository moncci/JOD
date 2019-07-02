using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Enum
{
    /// <summary>
    /// 文本对齐方式
    /// </summary>
    public enum TextAlignEnum
    {
        [XmlEnum("start")]
        /// <summary>
        /// 左对齐
        /// </summary>
        start,
        /// <summary>
        /// 居中对齐
        /// </summary>
        [XmlEnum("center")]
        center,
        /// <summary>
        /// 右对齐
        /// </summary>
        [XmlEnum("end")]
        end,
        /// <summary>
        /// 两端对齐
        /// </summary>
        [XmlEnum("justify")]
        justify
    }
}
