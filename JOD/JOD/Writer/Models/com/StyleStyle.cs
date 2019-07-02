using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    /// <summary>
    /// 样式类
    /// </summary>
    public class StyleStyle
    {
        /// <summary>
        /// 样式名称
        /// </summary>
        [XmlAttribute(WriterKeyword.style_name)]
        public string style_name { get; set; }

        /// <summary>
        /// 样式显示名称
        /// </summary>
        [XmlAttribute(WriterKeyword.style_display_name)]
        public string style_display_name { get; set; }

        /// <summary>
        /// 样式类别
        /// </summary>
        [XmlAttribute(WriterKeyword.style_family)]
        public string style_family { get; set; }

        /// <summary>
        /// 父样式名称
        /// </summary>
        [XmlAttribute(WriterKeyword.style_parent_style_name)]
        public string style_parent_style_name { get; set; }

        [XmlAttribute(WriterKeyword.style_next_style_name)]
        public string style_next_style_name { get; set; }

        [XmlAttribute(WriterKeyword.style_class)]
        public string style_class { get; set; }

        /// <summary>
        /// 段落属性
        /// </summary>
        [XmlElement(WriterKeyword.style_paragraph_properties)]
        public StyleParagraphProperties style_paragraph_properties { get; set; }

        /// <summary>
        /// 文本属性
        /// </summary>
        [XmlElement(WriterKeyword.style_text_properties)]
        public StyleTextProperties style_text_properties { get; set; }

        [XmlElement(WriterKeyword.style_table_properties)]
        public StyleTableProperties style_table_properties { get; set; }

        [XmlElement(WriterKeyword.style_table_column_properties)]
        public StyleTableColumnProperties style_table_column_properties { get; set; }

        [XmlElement(WriterKeyword.style_table_cell_properties)]
        public StyleTableCellProperties style_table_cell_properties { get; set; }

        [XmlElement(WriterKeyword.style_graphic_properties)]
        public StyleGraphicProperties style_graphic_properties { get; set; }
    }
}
