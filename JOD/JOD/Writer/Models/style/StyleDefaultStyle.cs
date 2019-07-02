using JOD.Writer.Models.com;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class StyleDefaultStyle
    {
        [XmlAttribute(StyleKeyword.style_family)]
        public string style_family { get; set; }

        [XmlElement(StyleKeyword.style_graphic_properties)]
        public StyleGraphicProperties style_graphic_properties { get; set; }

        [XmlElement(StyleKeyword.style_paragraph_properties)]
        public StyleParagraphProperties style_paragraph_properties { get; set; }

        [XmlElement(StyleKeyword.style_text_properties)]
        public StyleTextProperties style_text_properties { get; set; }

        [XmlElement(StyleKeyword.style_table_properties)]
        public StyleTableProperties style_table_properties { get; set; }

        [XmlElement(StyleKeyword.style_table_row_properties)]
        public StyleTableRowProperties style_table_row_properties { get; set; }
    }
}
