using JOD.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleTableProperties
    {
        [XmlIgnore]
        public double? style_width_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_width)]
        public string style_width {
            get
            {
                return IgnoreHelper.CMToString(style_width_忽略);
            }
            set
            {
                style_width_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlAttribute(WriterKeyword.table_align)]
        public string table_align { get; set; }

        [XmlAttribute(WriterKeyword.table_border_model)]
        public string table_border_model { get; set; }
    }
}
