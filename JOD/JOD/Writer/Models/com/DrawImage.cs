using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class DrawImage
    {
        [XmlAttribute(WriterKeyword.xlink_href)]
        public string xlink_href { get; set; }

        [XmlAttribute(WriterKeyword.xlink_type)]
        public string xlink_type { get; set; }

        [XmlAttribute(WriterKeyword.xlink_show)]
        public string xlink_show { get; set; }

        [XmlAttribute(WriterKeyword.xlink_actuate)]
        public string xlink_actuate { get; set; }

        [XmlAttribute(WriterKeyword.loext_mime_type)]
        public string loext_mime_type { get; set; }
    }
}
