using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class TextNotesConfiguration
    {
        [XmlAttribute(StyleKeyword.text_note_class)]
        public string text_note_class { get; set; }

        [XmlAttribute(StyleKeyword.style_num_format)]
        public string style_num_format { get; set; }

        [XmlAttribute(StyleKeyword.text_start_value)]
        public string text_start_value { get; set; }

        [XmlAttribute(StyleKeyword.text_footnotes_position)]
        public string text_footnotes_position { get; set; }

        [XmlAttribute(StyleKeyword.text_start_numbering_at)]
        public string text_start_numbering_at { get; set; }
    }
}
