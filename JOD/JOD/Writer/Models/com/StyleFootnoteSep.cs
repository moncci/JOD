using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleFootnoteSep
    {
        [XmlAttribute(WriterKeyword.style_width)]
        public string style_width { get; set; }

        [XmlAttribute(WriterKeyword.style_distance_before_sep)]
        public string style_distance_before_sep { get; set; }

        [XmlAttribute(WriterKeyword.style_distance_after_sep)]
        public string style_distance_after_sep { get; set; }

        [XmlAttribute(WriterKeyword.style_line_style)]
        public string style_line_style { get; set; }

        [XmlAttribute(WriterKeyword.style_adjustment)]
        public string style_adjustment { get; set; }

        [XmlAttribute(WriterKeyword.style_rel_width)]
        public string style_rel_width { get; set; }

        [XmlAttribute(WriterKeyword.style_color)]
        public string style_color { get; set; }
    }
}
