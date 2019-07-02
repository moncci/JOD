using JOD.Utils;
using JOD.Writer.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    /// <summary>
    /// 样式段落属性
    /// </summary>
    public class StyleParagraphProperties
    {
        /// <summary>
        /// 段落文本对齐方式
        /// </summary>
        [XmlIgnore]
        public TextAlignEnum? fo_text_align_忽略 { get; set; }

        /// <summary>
        /// 段落文本对齐方式
        /// </summary>
        [XmlAttribute(WriterKeyword.fo_text_align)]
        public string fo_text_align
        {
            get
            {
                return IgnoreHelper.TextAlignEnumToString(fo_text_align_忽略);
            }
            set
            {
                fo_text_align_忽略 = IgnoreHelper.StringToTextAlignEnum(value);
            }
        }

        [XmlIgnore]
        public bool? style_justify_single_word_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_justify_single_word)]
        public string style_justify_single_word
        {
            get
            {
                return IgnoreHelper.BoolToString(style_justify_single_word_忽略);
            }
            set
            {
                style_justify_single_word_忽略 = IgnoreHelper.StringToBool(value);
            }
        }

        [XmlAttribute(WriterKeyword.fo_orphans)]
        public int fo_orphans { get; set; }

        [XmlAttribute(WriterKeyword.fo_widows)]
        public int fo_widows { get; set; }

        [XmlAttribute(WriterKeyword.fo_hyphenation_ladder_count)]
        public string fo_hyphenation_ladder_count { get; set; }

        [XmlAttribute(WriterKeyword.style_text_autospace)]
        public string style_text_autospace { get; set; }

        [XmlAttribute(WriterKeyword.style_punctuation_wrap)]
        public string style_punctuation_wrap { get; set; }

        [XmlAttribute(WriterKeyword.style_line_break)]
        public string style_line_break { get; set; }

        [XmlAttribute(WriterKeyword.style_tab_stop_distance)]
        public string style_tab_stop_distance { get; set; }

        [XmlAttribute(WriterKeyword.style_writing_mode)]
        public string style_writing_mode { get; set; }

        [XmlAttribute(WriterKeyword.style_font_independent_line_spacing)]
        public string style_font_independent_line_spacing { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_top)]
        public string fo_margin_top { get; set; }

        [XmlAttribute(WriterKeyword.fo_margin_bottom)]
        public string fo_margin_bottom { get; set; }

        [XmlAttribute(WriterKeyword.loext_contextual_spacing)]
        public string loext_contextual_spacing { get; set; }

        [XmlAttribute(WriterKeyword.text_number_lines)]
        public string text_number_lines { get; set; }

        [XmlAttribute(WriterKeyword.text_line_number)]
        public string text_line_number { get; set; }

        [XmlAttribute(WriterKeyword.fo_line_height)]
        public string fo_line_height { get; set; }

        [XmlAttribute(WriterKeyword.fo_keep_with_next)]
        public string fo_keep_with_next { get; set; }

        [XmlElement(WriterKeyword.style_tab_stops)]
        public StyleTabStops style_tab_stops { get; set; }
    }
}
