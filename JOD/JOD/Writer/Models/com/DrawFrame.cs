using JOD.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class DrawFrame
    {
        [XmlAttribute(WriterKeyword.draw_style_name)]
        public string draw_style_name { get; set; }

        [XmlAttribute(WriterKeyword.draw_name)]
        public string draw_name { get; set; }

        [XmlAttribute(WriterKeyword.text_anchor_type)]
        public string text_anchor_type { get; set; }

        [XmlIgnore]
        public double? svg_width_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.svg_width)]
        public string svg_width
        {
            get
            {
                return IgnoreHelper.CMToString(svg_width_忽略);
            }
            set
            {
                svg_width_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlIgnore]
        public double? svg_height_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.svg_height)]
        public string svg_height {
            get
            {
                return IgnoreHelper.CMToString(svg_height_忽略);
            }
            set
            {
                svg_height_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlAttribute(WriterKeyword.draw_z_index)]
        public string draw_z_index { get; set; }

        [XmlElement(WriterKeyword.draw_image)]
        public DrawImage draw_image { get; set; }
    }
}
