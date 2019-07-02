using JOD.Writer.Models.com;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class OfficeStyles
    {
        [XmlElement(StyleKeyword.style_default_style)]
        public List<StyleDefaultStyle> style_default_style { get; set; }

        [XmlElement(StyleKeyword.style_style)]
        public List<StyleStyle> style_style { get; set; }

        [XmlElement(StyleKeyword.text_outline_style)]
        public TextOutlineStyle text_outline_style { get; set; }

        [XmlElement(StyleKeyword.text_notes_configuration)]
        public List<TextNotesConfiguration> text_notes_configuration { get; set; }

        [XmlElement(StyleKeyword.text_linenumbering_configuration)]
        public TextLinenumberingConfiguration text_linenumbering_configuration { get; set; }

        public void CreateIni_style_default_style()
        {
            style_default_style = new List<StyleDefaultStyle>();
            var graphic = new StyleDefaultStyle()
            {
                style_family = "graphic",
                style_graphic_properties = new StyleGraphicProperties() { svg_stroke_color = "#3465a4", draw_fill_color = "#729fcf", fo_wrap_option = "no-wrap", draw_shadow_offset_x = "0.1181in", draw_shadow_offset_y = "0.1181in", draw_start_line_spacing_horizontal = "0.1114in", draw_start_line_spacing_vertical = "0.1114in", draw_end_line_spacing_horizontal = "0.1114in", draw_end_line_spacing_vertical = "0.1114in", style_flow_with_text = "false" },
                style_paragraph_properties = new StyleParagraphProperties() { style_text_autospace = "ideograph-alpha", style_line_break = "strict", style_font_independent_line_spacing = "false", style_tab_stops = new StyleTabStops() },
                style_text_properties = new StyleTextProperties() { style_use_window_font_color = "true", style_font_name = "Liberation Serif", fo_font_size = "12pt", fo_language = "en", fo_country = "US", style_letter_kerning = "true", style_font_name_asian = "SimSun", style_font_size_asian = "10.5pt", style_language_asian = "zh", style_country_asian = "CN", style_font_name_complex = "Mangal", style_font_size_complex = "12pt", style_language_complex = "hi", style_country_complex = "IN" }
            };
            style_default_style.Add(graphic);

            var paragraph = new StyleDefaultStyle()
            {
                style_family = "paragraph",
                style_paragraph_properties = new StyleParagraphProperties() { fo_orphans = 2, fo_widows = 2, fo_hyphenation_ladder_count = "no-limit", style_text_autospace = "ideograph-alpha", style_punctuation_wrap = "hanging", style_line_break = "strict", style_tab_stop_distance = "0.4925in", style_writing_mode = "page" },
                style_text_properties = new StyleTextProperties() { style_use_window_font_color = "true", style_font_name = "Liberation Serif", fo_font_size = "12pt", fo_language = "en", fo_country = "US", style_letter_kerning = "true", style_font_name_asian = "SimSun", style_font_size_asian = "10.5pt", style_language_asian = "zh", style_country_asian = "CN", style_font_name_complex = "Mangal", style_font_size_complex = "12pt", style_language_complex = "hi", style_country_complex = "IN", fo_hyphenate = "false", fo_hyphenation_remain_char_count = "2", fo_hyphenation_push_char_count = "2" }
            };
            style_default_style.Add(paragraph);

            var table = new StyleDefaultStyle()
            {
                style_family = "table",
                style_table_properties = new StyleTableProperties() { table_border_model = "collapsing" }
            };
            style_default_style.Add(table);

            var table_row = new StyleDefaultStyle()
            {
                style_family = "table-row",
                style_table_row_properties = new StyleTableRowProperties() { fo_keep_together = "auto" }
            };
            style_default_style.Add(table_row);
        }

        public void CreateIni_style_style()
        {
            style_style = new List<StyleStyle>();
            var Standard = new StyleStyle()
            {
                style_name = "Standard",
                style_family = "paragraph",
                style_class = "text"
            };
            style_style.Add(Standard);

            var Heading = new StyleStyle()
            {
                style_name = "Heading",
                style_family = "paragraph",
                style_parent_style_name = "Standard",
                style_next_style_name = "Text_20_body",
                style_class = "text",
                style_paragraph_properties = new StyleParagraphProperties() { fo_margin_top = "0.1665in", fo_margin_bottom = "0.0835in", loext_contextual_spacing = "false", fo_keep_with_next = "always" },
                style_text_properties = new StyleTextProperties() { style_font_name = "Liberation Sans", fo_font_family = "'Liberation Sans'", style_font_family_generic = "swiss", style_font_pitch = "variable", fo_font_size = "14pt", style_font_name_asian = "Microsoft YaHei", style_font_family_asian = "'Microsoft YaHei'", style_font_family_generic_asian = "system", style_font_pitch_asian = "variable", style_font_size_asian = "14pt", style_font_name_complex = "Mangal", style_font_family_complex = "Mangal", style_font_family_generic_complex = "system", style_font_pitch_complex = "variable", style_font_size_complex = "14pt" }
            };
            style_style.Add(Heading);

            var Text_20_body = new StyleStyle()
            {
                style_name = "Text_20_body",
                style_display_name = "Text body",
                style_family = "paragraph",
                style_parent_style_name = "Standard",
                style_class = "text",
                style_paragraph_properties = new StyleParagraphProperties() { fo_margin_top = "0in", fo_margin_bottom = "0.0972in", loext_contextual_spacing = "false", fo_line_height = "120%" }
            };
            style_style.Add(Text_20_body);

            var List = new StyleStyle()
            {
                style_name = "List",
                style_family = "paragraph",
                style_parent_style_name = "Text_20_body",
                style_class = "list",
                style_text_properties = new StyleTextProperties() { style_font_size_asian = "12pt", style_font_name_complex = "Mangal1", style_font_family_complex = "Mangal" }
            };
            style_style.Add(List);

            var Caption = new StyleStyle()
            {
                style_name = "Caption",
                style_family = "paragraph",
                style_parent_style_name = "Standard",
                style_class = "extra",
                style_paragraph_properties = new StyleParagraphProperties() { fo_margin_top = "0.0835in", fo_margin_bottom = "0.0835in", loext_contextual_spacing = "false", text_number_lines = "false", text_line_number = "0" },
                style_text_properties = new StyleTextProperties() { fo_font_size = "12pt", fo_font_style = "italic", style_font_size_asian = "12pt", style_font_style_asian = "italic", style_font_name_complex = "Mangal1", style_font_family_complex = "Mangal", style_font_size_complex = "12pt", style_font_style_complex = "italic" }
            };
            style_style.Add(Caption);

            var Index = new StyleStyle()
            {
                style_name = "Index",
                style_family = "paragraph",
                style_parent_style_name = "Standard",
                style_class = "index",
                style_paragraph_properties = new StyleParagraphProperties() { text_number_lines = "false", text_line_number = "0" },
                style_text_properties = new StyleTextProperties() { style_font_size_asian = "12pt", style_font_name_complex = "Mangal1", style_font_family_complex = "Mangal" }
            };
            style_style.Add(Index);

            var Table_20_Contents = new StyleStyle()
            {
                style_name = "Table_20_Contents",
                style_display_name = "Table Contents",
                style_family = "paragraph",
                style_parent_style_name = "Standard",
                style_class = "extra",
                style_paragraph_properties = new StyleParagraphProperties() { text_number_lines = "false", text_line_number = "0" }
            };
            style_style.Add(Table_20_Contents);

            var Graphics = new StyleStyle()
            {
                style_name = "Graphics",
                style_family = "graphic",
                style_graphic_properties = new StyleGraphicProperties() { text_anchor_type = "paragraph",svg_x = "0cm",svg_y = "0cm",style_wrap= "dynamic",style_number_wrapped_paragraphs= "no-limit",style_wrap_contour= "false",style_vertical_pos= "top",style_vertical_rel= "paragraph",style_horizontal_pos= "center",style_horizontal_rel= "paragraph" }
            };
            style_style.Add(Graphics);
        }

        public void CreateIni_text_outline_style()
        {
            text_outline_style = new TextOutlineStyle()
            {
                style_name = "Outline",
                text_outline_level_style = new List<TextOutlineLevelStyle>()
            };

            var a1 = new TextOutlineLevelStyle()
            {
                text_level = "1",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a1);

            var a2 = new TextOutlineLevelStyle()
            {
                text_level = "2",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a2);

            var a3 = new TextOutlineLevelStyle()
            {
                text_level = "3",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a3);

            var a4 = new TextOutlineLevelStyle()
            {
                text_level = "4",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a4);

            var a5 = new TextOutlineLevelStyle()
            {
                text_level = "5",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a5);

            var a6 = new TextOutlineLevelStyle()
            {
                text_level = "6",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a6);

            var a7 = new TextOutlineLevelStyle()
            {
                text_level = "7",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a7);

            var a8 = new TextOutlineLevelStyle()
            {
                text_level = "8",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a8);

            var a9 = new TextOutlineLevelStyle()
            {
                text_level = "9",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a9);

            var a10 = new TextOutlineLevelStyle()
            {
                text_level = "10",
                style_num_format = "",
                style_list_level_properties = new StyleListLevelProperties()
                {
                    text_list_level_position_and_space_mode = "label-alignment",
                    style_list_level_label_alignment = new StyleListLevelLabelAlignment()
                    {
                        text_label_followed_by = "listtab"
                    }
                }
            };
            text_outline_style.text_outline_level_style.Add(a10);
        }

        public void CreateIni_text_notes_configuration()
        {
            text_notes_configuration = new List<TextNotesConfiguration>();
            var footnote = new TextNotesConfiguration()
            {
                text_note_class = "footnote",
                style_num_format = "1",
                text_start_value = "0",
                text_footnotes_position = "page",
                text_start_numbering_at = "document"
            };
            text_notes_configuration.Add(footnote);

            var endnote = new TextNotesConfiguration()
            {
                text_note_class = "endnote",
                style_num_format = "i",
                text_start_value = "0"
            };
            text_notes_configuration.Add(endnote);
        }

        public void CreateIni_text_linenumbering_configuration()
        {
            text_linenumbering_configuration = new TextLinenumberingConfiguration()
            {
                text_number_lines = "false",
                text_offset = "0.1965in",
                style_num_format = "1",
                text_number_position = "left",
                text_increment = "5"
            };
        }
    }
}
