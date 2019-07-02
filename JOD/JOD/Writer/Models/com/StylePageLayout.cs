using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StylePageLayout
    {
        [XmlAttribute(WriterKeyword.style_name)]
        public string style_name { get; set; }

        [XmlElement(WriterKeyword.style_page_layout_properties)]
        public StylePageLayoutProperties style_page_layout_properties { get; set; }

        [XmlElement(WriterKeyword.style_header_style)]
        public StyleHeaderStyle style_header_style { get; set; }

        [XmlElement(WriterKeyword.style_footer_style)]
        public StyleFooterStyle style_footer_style { get; set; }
    }
}
