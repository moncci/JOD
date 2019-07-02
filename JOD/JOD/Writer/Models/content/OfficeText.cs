using JOD.Writer.Models.com;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.content
{
    [XmlInclude(typeof(TableTable))]
    [XmlInclude(typeof(TextP))]
    public class OfficeText
    {
        [XmlElement(ContentKeyword.text_sequence_decls)]
        public TextSequenceDecls text_sequence_decls { get; set; }

        /// <summary>
        /// 文档主内容
        /// </summary>
        //[XmlElement(ContentKeyword.text_p)]
        [XmlElement(Type = typeof(TableTable), ElementName = WriterKeyword.table_table)]
        [XmlElement(Type = typeof(TextP), ElementName = WriterKeyword.text_p)]
        public List<TextElement> text_element { get; set; }

        public OfficeText()
        {
            text_sequence_decls = new TextSequenceDecls();
            text_element = new List<TextElement>();
        }
    }
}
