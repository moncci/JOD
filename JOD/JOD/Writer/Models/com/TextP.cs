using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class TextP : TextElement
    {
        [XmlAttribute(WriterKeyword.text_style_name)]
        public string text_style_name { get; set; }
        [XmlText]
        public string text { get; set; }

        [XmlElement(WriterKeyword.draw_frame)]
        public DrawFrame draw_frame { get; set; }
    }
}
