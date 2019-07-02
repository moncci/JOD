using JOD.Utils;
using JOD.Writer.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleTextProperties
    {
        [XmlAttribute(WriterKeyword.fo_color)]
        public string fo_color { get; set; }

        [XmlAttribute(WriterKeyword.style_use_window_font_color)]
        public string style_use_window_font_color { get; set; }

        [XmlAttribute(WriterKeyword.style_font_name)]
        public string style_font_name { get; set; }

        [XmlAttribute(WriterKeyword.fo_font_family)]
        public string fo_font_family { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_generic)]
        public string style_font_family_generic { get; set; }

        [XmlAttribute(WriterKeyword.style_font_pitch)]
        public string style_font_pitch { get; set; }

        /// <summary>
        /// 删除线样式
        /// </summary>
        [XmlIgnore]
        public TextLineThroughStyle? style_text_line_through_style_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_text_line_through_style)]
        public string style_text_line_through_style
        {
            get
            {
                return IgnoreHelper.TextLineThroughStyleEnumToString(style_text_line_through_style_忽略);
            }
            set
            {
                style_text_line_through_style_忽略 = IgnoreHelper.StringToTextLineThroughStyleEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public TextLineThroughType? style_text_line_through_type_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_text_line_through_type)]
        public string style_text_line_through_type
        {
            get
            {
                return IgnoreHelper.TextLineThroughTypeEnumToString(style_text_line_through_type_忽略);
            }
            set
            {
                style_text_line_through_type_忽略 = IgnoreHelper.StringToTextLineThroughTypeEnum(value);
            }
        }

        /// <summary>
        /// 字号
        /// </summary>
        [XmlIgnore]
        public FontSizeEnum? fo_font_size_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_font_size)]
        public string fo_font_size
        {
            get
            {
                return IgnoreHelper.FontSizeEnumToString(fo_font_size_忽略);
            }
            set
            {
                fo_font_size_忽略 = IgnoreHelper.StringToFontSizeEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FtStyleEnum? fo_font_style_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_font_style)]
        public string fo_font_style
        {
            get
            {
                return IgnoreHelper.FtStyleEnumToString(fo_font_style_忽略);
            }
            set
            {
                fo_font_style_忽略 = IgnoreHelper.StringToFtStyleEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public TextUnderlineStyle? style_text_underline_style_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_text_underline_style)]
        public string style_text_underline_style
        {
            get
            {
                return IgnoreHelper.TextUnderlineStyleEnumToString(style_text_underline_style_忽略);
            }
            set
            {
                style_text_underline_style_忽略 = IgnoreHelper.StringToTextUnderlineStyleEnum(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_text_underline_width)]
        public string style_text_underline_width { get; set; }

        [XmlAttribute(WriterKeyword.style_text_underline_color)]
        public string style_text_underline_color { get; set; }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FontWeightEnum? fo_font_weight_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.fo_font_weight)]
        public string fo_font_weight
        {
            get
            {
                return IgnoreHelper.FontWeightEnumToString(fo_font_weight_忽略);
            }
            set
            {
                fo_font_weight_忽略 = IgnoreHelper.StringToFontWeightEnum(value);
            }
        }

        [XmlAttribute(WriterKeyword.fo_background_color)]
        public string fo_background_color { get; set; }

        [XmlAttribute(WriterKeyword.fo_language)]
        public string fo_language { get; set; }

        [XmlAttribute(WriterKeyword.fo_country)]
        public string fo_country { get; set; }

        [XmlAttribute(WriterKeyword.officeooo_rsid)]
        public string officeooo_rsid { get; set; }

        [XmlAttribute(WriterKeyword.officeooo_paragraph_rsid)]
        public string officeooo_paragraph_rsid { get; set; }

        [XmlAttribute(WriterKeyword.style_letter_kerning)]
        public string style_letter_kerning { get; set; }

        [XmlAttribute(WriterKeyword.style_font_name_asian)]
        public string style_font_name_asian { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_asian)]
        public string style_font_family_asian { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_generic_asian)]
        public string style_font_family_generic_asian { get; set; }

        [XmlAttribute(WriterKeyword.style_font_pitch_asian)]
        public string style_font_pitch_asian { get; set; }

        /// <summary>
        /// 字号
        /// </summary>
        [XmlIgnore]
        public FontSizeEnum? style_font_size_asian_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_size_asian)]
        public string style_font_size_asian
        {
            get
            {
                return IgnoreHelper.FontSizeEnumToString(style_font_size_asian_忽略);
            }
            set
            {
                style_font_size_asian_忽略 = IgnoreHelper.StringToFontSizeEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FontWeightEnum? style_font_weight_asian_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_weight_asian)]
        public string style_font_weight_asian
        {
            get
            {
                return IgnoreHelper.FontWeightEnumToString(style_font_weight_asian_忽略);
            }
            set
            {
                style_font_weight_asian_忽略 = IgnoreHelper.StringToFontWeightEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FtStyleEnum? style_font_style_asian_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_style_asian)]
        public string style_font_style_asian
        {
            get
            {
                return IgnoreHelper.FtStyleEnumToString(style_font_style_asian_忽略);
            }
            set
            {
                style_font_style_asian_忽略 = IgnoreHelper.StringToFtStyleEnum(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_language_asian)]
        public string style_language_asian { get; set; }

        [XmlAttribute(WriterKeyword.style_country_asian)]
        public string style_country_asian { get; set; }

        [XmlAttribute(WriterKeyword.style_font_name_complex)]
        public string style_font_name_complex { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_complex)]
        public string style_font_family_complex { get; set; }

        [XmlAttribute(WriterKeyword.style_font_family_generic_complex)]
        public string style_font_family_generic_complex { get; set; }

        [XmlAttribute(WriterKeyword.style_font_pitch_complex)]
        public string style_font_pitch_complex { get; set; }

        /// <summary>
        /// 字号
        /// </summary>
        [XmlIgnore]
        public FontSizeEnum? style_font_size_complex_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_size_complex)]
        public string style_font_size_complex
        {
            get
            {
                return IgnoreHelper.FontSizeEnumToString(style_font_size_complex_忽略);
            }
            set
            {
                style_font_size_complex_忽略 = IgnoreHelper.StringToFontSizeEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FontWeightEnum? style_font_weight_complex_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_weight_complex)]
        public string style_font_weight_complex
        {
            get
            {
                return IgnoreHelper.FontWeightEnumToString(style_font_weight_complex_忽略);
            }
            set
            {
                style_font_weight_complex_忽略 = IgnoreHelper.StringToFontWeightEnum(value);
            }
        }

        /// <summary>
        /// 删除线类型
        /// </summary>
        [XmlIgnore]
        public FtStyleEnum? style_font_style_complex_忽略 { get; set; }

        [XmlAttribute(WriterKeyword.style_font_style_complex)]
        public string style_font_style_complex
        {
            get
            {
                return IgnoreHelper.FtStyleEnumToString(style_font_style_complex_忽略);
            }
            set
            {
                style_font_style_complex_忽略 = IgnoreHelper.StringToFtStyleEnum(value);
            }
        }

        [XmlAttribute(WriterKeyword.style_language_complex)]
        public string style_language_complex { get; set; }

        [XmlAttribute(WriterKeyword.style_country_complex)]
        public string style_country_complex { get; set; }

        [XmlAttribute(WriterKeyword.fo_hyphenate)]
        public string fo_hyphenate { get; set; }

        [XmlAttribute(WriterKeyword.fo_hyphenation_remain_char_count)]
        public string fo_hyphenation_remain_char_count { get; set; }

        [XmlAttribute(WriterKeyword.fo_hyphenation_push_char_count)]
        public string fo_hyphenation_push_char_count { get; set; }
    }
}
