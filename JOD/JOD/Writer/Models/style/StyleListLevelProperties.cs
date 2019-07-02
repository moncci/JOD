using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class StyleListLevelProperties
    {
        [XmlAttribute(StyleKeyword.text_list_level_position_and_space_mode)]
        public string text_list_level_position_and_space_mode { get; set; }

        [XmlElement(StyleKeyword.style_list_level_label_alignment)]
        public StyleListLevelLabelAlignment style_list_level_label_alignment { get; set; }
    }
}
