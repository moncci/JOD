using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.meta
{
    public class MetaDocumentStatistic
    {
        [XmlAttribute(MetaKeyword.meta_table_count)]
        public int meta_table_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_image_count)]
        public int meta_image_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_object_count)]
        public int meta_object_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_page_count)]
        public int meta_page_count { get; set; } = 1;

        [XmlAttribute(MetaKeyword.meta_paragraph_count)]
        public int meta_paragraph_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_word_count)]
        public int meta_word_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_character_count)]
        public int meta_character_count { get; set; } = 0;

        [XmlAttribute(MetaKeyword.meta_non_whitespace_character_count)]
        public int meta_non_whitespace_character_count { get; set; } = 0;

    }
}
