using JOD.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleTableColumnProperties
    {
        [XmlIgnore]
        public double? style_column_width_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_column_width)]
        public string style_column_width
        {
            get
            {
                return IgnoreHelper.CMToString(style_column_width_忽略);
            }
            set
            {
                style_column_width_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_rel_column_width)]
        public string style_rel_column_width { get; set; }
    }
}
