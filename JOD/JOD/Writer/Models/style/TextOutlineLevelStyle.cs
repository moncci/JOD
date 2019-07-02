using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class TextOutlineLevelStyle
    {
        [XmlAttribute(StyleKeyword.text_level)]
        public string text_level { get; set; }

        [XmlAttribute(StyleKeyword.style_num_format)]
        public string style_num_format { get; set; }

        [XmlElement(StyleKeyword.style_list_level_properties)]
        public StyleListLevelProperties style_list_level_properties { get; set; }
    }
}
