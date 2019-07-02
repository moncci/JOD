using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer.Models.content
{
    public class ContentKeyword : WriterKeyword
    {
        [XmlKeyword("office:document-content")]
        public const string office_document_content = "office" + General.CONLON + "document-content";




        [XmlKeyword("office:scripts")]
        public const string office_scripts = "office" + General.CONLON + "scripts";



        [XmlKeyword("office:body")]
        public const string office_body = "office" + General.CONLON + "body";



        [XmlKeyword("office:text")]
        public const string office_text = "office" + General.CONLON + "text";



        [XmlKeyword("text:sequence-decls")]
        public const string text_sequence_decls = "text" + General.CONLON + "sequence-decls";




        [XmlKeyword("text:sequence-decl")]
        public const string text_sequence_decl = "text" + General.CONLON + "sequence-decl";

        [XmlKeyword("text:display-outline-level")]
        public const string text_display_outline_level = "text" + General.CONLON + "display-outline-level";

        [XmlKeyword("text:name")]
        public const string text_name = "text" + General.CONLON + "name";

    }
}
