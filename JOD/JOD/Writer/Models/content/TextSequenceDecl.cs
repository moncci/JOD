using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.content
{
    public class TextSequenceDecl
    {
        [XmlAttribute(ContentKeyword.text_display_outline_level)]
        public string text_display_outline_level { get; set; }

        [XmlAttribute(ContentKeyword.text_name)]
        public string text_name { get; set; }
    }
}
