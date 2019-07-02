using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class TextLinenumberingConfiguration
    {
        [XmlAttribute(StyleKeyword.text_number_lines)]
        public string text_number_lines { get; set; }

        [XmlAttribute(StyleKeyword.text_offset)]
        public string text_offset { get; set; }

        [XmlAttribute(StyleKeyword.style_num_format)]
        public string style_num_format { get; set; }

        [XmlAttribute(StyleKeyword.text_number_position)]
        public string text_number_position { get; set; }

        [XmlAttribute(StyleKeyword.text_increment)]
        public string text_increment { get; set; }
    }
}
