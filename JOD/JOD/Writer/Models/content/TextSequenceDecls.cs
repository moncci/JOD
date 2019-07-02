using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.content
{
    public class TextSequenceDecls
    {
        [XmlElement(ContentKeyword.text_sequence_decl)]
        public List<TextSequenceDecl> text_sequence_decl { get; set; }

        public TextSequenceDecls()
        {
            text_sequence_decl = new List<TextSequenceDecl>();
            text_sequence_decl.Add(new TextSequenceDecl() { text_display_outline_level = "0", text_name = "Illustration" });
            text_sequence_decl.Add(new TextSequenceDecl() { text_display_outline_level = "0", text_name = "Table" });
            text_sequence_decl.Add(new TextSequenceDecl() { text_display_outline_level = "0", text_name = "Text" });
            text_sequence_decl.Add(new TextSequenceDecl() { text_display_outline_level = "0", text_name = "Drawing" });
        }
    }
}
