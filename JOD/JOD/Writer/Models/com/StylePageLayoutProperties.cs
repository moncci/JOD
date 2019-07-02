using JOD.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StylePageLayoutProperties
    {
        [XmlIgnore]
        public double? fo_page_width_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_page_width)]
        public string fo_page_width
        {
            get
            {
                return IgnoreHelper.CMToString(fo_page_width_忽略);
            }
            set
            {
                fo_page_width_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlIgnore]
        public double? fo_page_height_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_page_height)]
        public string fo_page_height
        {
            get
            {
                return IgnoreHelper.CMToString(fo_page_height_忽略);
            }
            set
            {
                fo_page_height_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_num_format)]
        public string style_num_format { get; set; }

        [XmlAttribute(WriterKeyword.style_print_orientation)]
        public string style_print_orientation { get; set; }

        [XmlIgnore]
        public double? fo_margin_top_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_top)]
        public string fo_margin_top
        {
            get
            {
                return IgnoreHelper.CMToString(fo_margin_top_忽略);
            }
            set
            {
                fo_margin_top_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlIgnore]
        public double? fo_margin_bottom_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_bottom)]
        public string fo_margin_bottom
        {
            get
            {
                return IgnoreHelper.CMToString(fo_margin_bottom_忽略);
            }
            set
            {
                fo_margin_bottom_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlIgnore]
        public double? fo_margin_left_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_left)]
        public string fo_margin_left
        {
            get
            {
                return IgnoreHelper.CMToString(fo_margin_left_忽略);
            }
            set
            {
                fo_margin_left_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlIgnore]
        public double? fo_margin_right_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_right)]
        public string fo_margin_right
        {
            get
            {
                return IgnoreHelper.CMToString(fo_margin_right_忽略);
            }
            set
            {
                fo_margin_right_忽略 = IgnoreHelper.StringToCM(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_writing_mode)]
        public string style_writing_mode { get; set; }

        [XmlAttribute(WriterKeyword.style_footnote_max_height)]
        public string style_footnote_max_height { get; set; }

        [XmlElement(WriterKeyword.style_footnote_sep)]
        public StyleFootnoteSep style_footnote_sep { get; set; }
    }
}
