using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class TextOutlineStyle
    {
        [XmlAttribute(StyleKeyword.style_name)]
        public string style_name { get; set; }

        [XmlElement(StyleKeyword.text_outline_level_style)]
        public List<TextOutlineLevelStyle> text_outline_level_style { get; set; }
    }
}
