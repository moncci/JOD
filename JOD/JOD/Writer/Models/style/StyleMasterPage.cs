using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class StyleMasterPage
    {
        [XmlAttribute(StyleKeyword.style_name)]
        public string style_name { get; set; }

        [XmlAttribute(StyleKeyword.style_page_layout_name)]
        public string style_page_layout_name { get; set; }
    }
}
