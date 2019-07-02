using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer.Models.style
{
    public class StyleKeyword : WriterKeyword
    {
        [XmlKeyword("office:document-styles")]
        public const string office_document_styles = "office" + General.CONLON + "document-styles";        



        [XmlKeyword("office:styles")]
        public const string office_styles = "office" + General.CONLON + "styles";




        [XmlKeyword("style:default-style")]
        public const string style_default_style = "style" + General.CONLON + "default-style";        




        [XmlKeyword("text:outline-style")]
        public const string text_outline_style = "text" + General.CONLON + "outline-style";

        //[XmlKeyword("style:name")]
        //public const string style_name = "style" + General.CONLON + "name";




        [XmlKeyword("text:outline-level-style")]
        public const string text_outline_level_style = "text" + General.CONLON + "outline-level-style";

        [XmlKeyword("text:level")]
        public const string text_level = "text" + General.CONLON + "level";        




        [XmlKeyword("style:list-level-properties")]
        public const string style_list_level_properties = "style" + General.CONLON + "list-level-properties";

        [XmlKeyword("text:list-level-position-and-space-mode")]
        public const string text_list_level_position_and_space_mode = "text" + General.CONLON + "list-level-position-and-space-mode";




        [XmlKeyword("style:list-level-label-alignment")]
        public const string style_list_level_label_alignment = "style" + General.CONLON + "list-level-label-alignment";

        [XmlKeyword("text:label-followed-by")]
        public const string text_label_followed_by = "text" + General.CONLON + "label-followed-by";




        [XmlKeyword("text:notes-configuration")]
        public const string text_notes_configuration = "text" + General.CONLON + "notes-configuration";

        [XmlKeyword("text:note-class")]
        public const string text_note_class = "text" + General.CONLON + "note-class";

        //[XmlKeyword("style:num-format")]
        //public const string style_num_format = "style" + General.CONLON + "num-format";

        [XmlKeyword("text:start-value")]
        public const string text_start_value = "text" + General.CONLON + "start-value";

        [XmlKeyword("text:footnotes-position")]
        public const string text_footnotes_position = "text" + General.CONLON + "footnotes-position";

        [XmlKeyword("text:start-numbering-at")]
        public const string text_start_numbering_at = "text" + General.CONLON + "start-numbering-at";




        [XmlKeyword("text:linenumbering-configuration")]
        public const string text_linenumbering_configuration = "text" + General.CONLON + "linenumbering-configuration";

        //[XmlKeyword("text:number-lines")]
        //public const string text_number_lines = "text" + General.CONLON + "number-lines";

        [XmlKeyword("text:offset")]
        public const string text_offset = "text" + General.CONLON + "offset";

        //[XmlKeyword("style:num-format")]
        //public const string style_num_format = "style" + General.CONLON + "num-format";

        [XmlKeyword("text:number-position")]
        public const string text_number_position = "text" + General.CONLON + "number-position";

        [XmlKeyword("text:increment")]
        public const string text_increment = "text" + General.CONLON + "increment";       




        [XmlKeyword("office:master-styles")]
        public const string office_master_styles = "office" + General.CONLON + "master-styles";

        [XmlKeyword("style:master-page")]
        public const string style_master_page = "style" + General.CONLON + "master-page";

        //[XmlKeyword("style:name")]
        //public const string style_name = "style" + General.CONLON + "name";

        [XmlKeyword("style:page-layout-name")]
        public const string style_page_layout_name = "style" + General.CONLON + "page-layout-name";
    }
}
