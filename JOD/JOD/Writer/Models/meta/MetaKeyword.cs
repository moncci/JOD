using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer.Models.meta
{
    public class MetaKeyword : WriterKeyword
    {
        [XmlKeyword("office:document-meta")]
        public const string office_document_meta = "office" + General.CONLON + "document-meta";
        [XmlKeyword("xmlns:office")]
        public const string xmlns_office = "xmlns" + General.CONLON + "office";
        [XmlKeyword("xmlns:xlink")]
        public const string xmlns_xlink = "xmlns" + General.CONLON + "xlink";
        [XmlKeyword("xmlns:dc")]
        public const string xmlns_dc = "xmlns" + General.CONLON + "dc";
        [XmlKeyword("xmlns:meta")]
        public const string xmlns_meta = "xmlns" + General.CONLON + "meta";
        [XmlKeyword("xmlns:ooo")]
        public const string xmlns_ooo = "xmlns" + General.CONLON + "ooo";
        [XmlKeyword("xmlns:grddl")]
        public const string xmlns_grddl = "xmlns" + General.CONLON + "grddl";
        [XmlKeyword("office:version")]
        public const string office_version = "office" + General.CONLON + "version";

        [XmlKeyword("office:meta")]
        public const string office_meta = "office" + General.CONLON + "meta";
        [XmlKeyword("meta:creation-date")]
        public const string meta_creation_date = "meta" + General.CONLON + "creation-date";
        [XmlKeyword("meta:document-statistic")]
        public const string meta_document_statistic = "meta" + General.CONLON + "document-statistic";
        [XmlKeyword("meta:table-count")]
        public const string meta_table_count = "meta" + General.CONLON + "table-count";
        [XmlKeyword("meta:image-count")]
        public const string meta_image_count = "meta" + General.CONLON + "image-count";
        [XmlKeyword("meta:object-count")]
        public const string meta_object_count = "meta" + General.CONLON + "object-count";
        [XmlKeyword("meta:page-count")]
        public const string meta_page_count = "meta" + General.CONLON + "page-count";
        [XmlKeyword("meta:paragraph-count")]
        public const string meta_paragraph_count = "meta" + General.CONLON + "paragraph-count";
        [XmlKeyword("meta:word-count")]
        public const string meta_word_count = "meta" + General.CONLON + "word-count";
        [XmlKeyword("meta:character-count")]
        public const string meta_character_count = "meta" + General.CONLON + "character-count";
        [XmlKeyword("meta:non-whitespace-character-count")]
        public const string meta_non_whitespace_character_count = "meta" + General.CONLON + "non-whitespace-character-count";


        [XmlKeyword("meta:generator")]
        public const string meta_generator = "meta" + General.CONLON + "generator";
    }
}
