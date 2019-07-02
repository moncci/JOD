using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleFontFace
    {
        [XmlAttribute(WriterKeyword.style_name)]
        public string style_name { get; set; }

        [XmlAttribute(WriterKeyword.svg_font_family)]
        public string svg_font_family { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_generic)]
        public string style_font_family_generic { get; set; }

        [XmlAttribute(WriterKeyword.style_font_pitch)]
        public string style_font_pitch { get; set; }
    }
}
