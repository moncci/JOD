using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleTableCellProperties
    {
        [XmlAttribute(WriterKeyword.fo_padding)]
        public string fo_padding { get; set; }

        [XmlAttribute(WriterKeyword.fo_border)]
        public string fo_border { get; set; }

        [XmlAttribute(WriterKeyword.fo_border_left)]
        public string fo_border_left { get; set; }

        [XmlAttribute(WriterKeyword.fo_border_right)]
        public string fo_border_right { get; set; }

        [XmlAttribute(WriterKeyword.fo_border_top)]
        public string fo_border_top { get; set; }

        [XmlAttribute(WriterKeyword.fo_border_bottom)]
        public string fo_border_bottom { get; set; }
    }
}
