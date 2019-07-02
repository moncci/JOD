using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer.Models
{
    public abstract class WriterKeyword
    {
        [XmlKeyword("xmlns:office")]
        public const string xmlns_office = "xmlns" + General.CONLON + "office";

        [XmlKeyword("xmlns:style")]
        public const string xmlns_style = "xmlns" + General.CONLON + "style";

        [XmlKeyword("xmlns:text")]
        public const string xmlns_text = "xmlns" + General.CONLON + "text";

        [XmlKeyword("xmlns:table")]
        public const string xmlns_table = "xmlns" + General.CONLON + "table";

        [XmlKeyword("xmlns:draw")]
        public const string xmlns_draw = "xmlns" + General.CONLON + "draw";

        [XmlKeyword("xmlns:fo")]
        public const string xmlns_fo = "xmlns" + General.CONLON + "fo";

        [XmlKeyword("xmlns:xlink")]
        public const string xmlns_xlink = "xmlns" + General.CONLON + "xlink";

        [XmlKeyword("xmlns:dc")]
        public const string xmlns_dc = "xmlns" + General.CONLON + "dc";

        [XmlKeyword("xmlns:meta")]
        public const string xmlns_meta = "xmlns" + General.CONLON + "meta";

        [XmlKeyword("xmlns:number")]
        public const string xmlns_number = "xmlns" + General.CONLON + "number";

        [XmlKeyword("xmlns:svg")]
        public const string xmlns_svg = "xmlns" + General.CONLON + "svg";

        [XmlKeyword("xmlns:chart")]
        public const string xmlns_chart = "xmlns" + General.CONLON + "chart";

        [XmlKeyword("xmlns:dr3d")]
        public const string xmlns_dr3d = "xmlns" + General.CONLON + "dr3d";

        [XmlKeyword("xmlns:math")]
        public const string xmlns_math = "xmlns" + General.CONLON + "math";

        [XmlKeyword("xmlns:form")]
        public const string xmlns_form = "xmlns" + General.CONLON + "form";

        [XmlKeyword("xmlns:script")]
        public const string xmlns_script = "xmlns" + General.CONLON + "script";

        [XmlKeyword("xmlns:ooo")]
        public const string xmlns_ooo = "xmlns" + General.CONLON + "ooo";

        [XmlKeyword("xmlns:ooow")]
        public const string xmlns_ooow = "xmlns" + General.CONLON + "ooow";

        [XmlKeyword("xmlns:oooc")]
        public const string xmlns_oooc = "xmlns" + General.CONLON + "oooc";

        [XmlKeyword("xmlns:dom")]
        public const string xmlns_dom = "xmlns" + General.CONLON + "dom";

        [XmlKeyword("xmlns:xforms")]
        public const string xmlns_xforms = "xmlns" + General.CONLON + "xforms";

        [XmlKeyword("xmlns:xsd")]
        public const string xmlns_xsd = "xmlns" + General.CONLON + "xsd";

        [XmlKeyword("xmlns:xsi")]
        public const string xmlns_xsi = "xmlns" + General.CONLON + "xsi";

        [XmlKeyword("xmlns:rpt")]
        public const string xmlns_rpt = "xmlns" + General.CONLON + "rpt";

        [XmlKeyword("xmlns:of")]
        public const string xmlns_of = "xmlns" + General.CONLON + "of";

        [XmlKeyword("xmlns:xhtml")]
        public const string xmlns_xhtml = "xmlns" + General.CONLON + "xhtml";

        [XmlKeyword("xmlns:grddl")]
        public const string xmlns_grddl = "xmlns" + General.CONLON + "grddl";

        [XmlKeyword("xmlns:officeooo")]
        public const string xmlns_officeooo = "xmlns" + General.CONLON + "officeooo";

        [XmlKeyword("xmlns:tableooo")]
        public const string xmlns_tableooo = "xmlns" + General.CONLON + "tableooo";

        [XmlKeyword("xmlns:drawooo")]
        public const string xmlns_drawooo = "xmlns" + General.CONLON + "drawooo";

        [XmlKeyword("xmlns:calcext")]
        public const string xmlns_calcext = "xmlns" + General.CONLON + "calcext";

        [XmlKeyword("xmlns:loext")]
        public const string xmlns_loext = "xmlns" + General.CONLON + "loext";

        [XmlKeyword("xmlns:field")]
        public const string xmlns_field = "xmlns" + General.CONLON + "field";

        [XmlKeyword("xmlns:formx")]
        public const string xmlns_formx = "xmlns" + General.CONLON + "formx";

        [XmlKeyword("xmlns:css3t")]
        public const string xmlns_css3t = "xmlns" + General.CONLON + "css3t";

        [XmlKeyword("office:version")]
        public const string office_version = "office" + General.CONLON + "version";




        [XmlKeyword("office:font-face-decls")]
        public const string office_font_face_decls = "office" + General.CONLON + "font-face-decls";




        [XmlKeyword("style:font-face")]
        public const string style_font_face = "style" + General.CONLON + "font-face";

        [XmlKeyword("style:name")]
        public const string style_name = "style" + General.CONLON + "name";

        [XmlKeyword("svg:font-family")]
        public const string svg_font_family = "svg" + General.CONLON + "font-family";

        [XmlKeyword("style:font-family-generic")]
        public const string style_font_family_generic = "style" + General.CONLON + "font-family-generic";

        [XmlKeyword("style:font-pitch")]
        public const string style_font_pitch = "style" + General.CONLON + "font-pitch";




        [XmlKeyword("office:automatic-styles")]
        public const string office_automatic_styles = "office" + General.CONLON + "automatic-styles";




        [XmlKeyword("style:page-layout")]
        public const string style_page_layout = "style" + General.CONLON + "page-layout";

        //[XmlKeyword("style:name")]
        //public const string style_name = "style" + General.CONLON + "name";




        [XmlKeyword("style:page-layout-properties")]
        public const string style_page_layout_properties = "style" + General.CONLON + "page-layout-properties";

        [XmlKeyword("fo:page-width")]
        public const string fo_page_width = "fo" + General.CONLON + "page-width";

        [XmlKeyword("fo:page-height")]
        public const string fo_page_height = "fo" + General.CONLON + "page-height";

        //[XmlKeyword("style:num-format")]
        //public const string style_num_format = "style" + General.CONLON + "num-format";

        [XmlKeyword("style:print-orientation")]
        public const string style_print_orientation = "style" + General.CONLON + "print-orientation";

        //[XmlKeyword("fo:margin-top")]
        //public const string fo_margin_top = "fo" + General.CONLON + "margin-top";

        //[XmlKeyword("fo:margin-bottom")]
        //public const string fo_margin_bottom = "fo" + General.CONLON + "margin-bottom";

        [XmlKeyword("fo:margin-left")]
        public const string fo_margin_left = "fo" + General.CONLON + "margin-left";

        [XmlKeyword("fo:margin-right")]
        public const string fo_margin_right = "fo" + General.CONLON + "margin-right";

        //[XmlKeyword("style:writing-mode")]
        //public const string style_writing_mode = "style" + General.CONLON + "writing-mode";

        [XmlKeyword("style:footnote-max-height")]
        public const string style_footnote_max_height = "style" + General.CONLON + "footnote-max-height";




        [XmlKeyword("style:footnote-sep")]
        public const string style_footnote_sep = "style" + General.CONLON + "footnote-sep";

        [XmlKeyword("style:width")]
        public const string style_width = "style" + General.CONLON + "width";

        [XmlKeyword("style:distance-before-sep")]
        public const string style_distance_before_sep = "style" + General.CONLON + "distance-before-sep";

        [XmlKeyword("style:distance-after-sep")]
        public const string style_distance_after_sep = "style" + General.CONLON + "distance-after-sep";

        [XmlKeyword("style:line-style")]
        public const string style_line_style = "style" + General.CONLON + "line-style";

        [XmlKeyword("style:adjustment")]
        public const string style_adjustment = "style" + General.CONLON + "adjustment";

        [XmlKeyword("style:rel-width")]
        public const string style_rel_width = "style" + General.CONLON + "rel-width";

        [XmlKeyword("style:color")]
        public const string style_color = "style" + General.CONLON + "color";




        [XmlKeyword("style:header-style")]
        public const string style_header_style = "style" + General.CONLON + "header-style";




        [XmlKeyword("style:footer-style")]
        public const string style_footer_style = "style" + General.CONLON + "footer-style";


        [XmlKeyword("style:num-format")]
        public const string style_num_format = "style" + General.CONLON + "num-format";


        [XmlKeyword("fo:margin-top")]
        public const string fo_margin_top = "fo" + General.CONLON + "margin-top";

        [XmlKeyword("fo:margin-bottom")]
        public const string fo_margin_bottom = "fo" + General.CONLON + "margin-bottom";

        [XmlKeyword("style:writing-mode")]
        public const string style_writing_mode = "style" + General.CONLON + "writing-mode";




        [XmlKeyword("style:style")]
        public const string style_style = "style" + General.CONLON + "style";

        //[XmlKeyword("style:name")]
        //public const string style_name = "style" + General.CONLON + "name";

        [XmlKeyword("style:family")]
        public const string style_family = "style" + General.CONLON + "family";

        [XmlKeyword("style:display-name")]
        public const string style_display_name = "style" + General.CONLON + "display-name";

        [XmlKeyword("style:parent-style-name")]
        public const string style_parent_style_name = "style" + General.CONLON + "parent-style-name";

        [XmlKeyword("style:next-style-name")]
        public const string style_next_style_name = "style" + General.CONLON + "next-style-name";

        [XmlKeyword("style:class")]
        public const string style_class = "style" + General.CONLON + "class";




        [XmlKeyword("style:paragraph-properties")]
        public const string style_paragraph_properties = "style" + General.CONLON + "paragraph-properties";

        [XmlKeyword("fo:text-align")]
        public const string fo_text_align = "fo" + General.CONLON + "text-align";

        [XmlKeyword("style:justify-single-word")]
        public const string style_justify_single_word = "style" + General.CONLON + "justify-single-word";

        [XmlKeyword("fo:orphans")]
        public const string fo_orphans = "fo" + General.CONLON + "orphans";

        [XmlKeyword("fo:widows")]
        public const string fo_widows = "fo" + General.CONLON + "widows";

        [XmlKeyword("fo:hyphenation-ladder-count")]
        public const string fo_hyphenation_ladder_count = "fo" + General.CONLON + "hyphenation-ladder-count";

        [XmlKeyword("style:text-autospace")]
        public const string style_text_autospace = "style" + General.CONLON + "text-autospace";

        [XmlKeyword("style:punctuation-wrap")]
        public const string style_punctuation_wrap = "style" + General.CONLON + "punctuation-wrap";

        [XmlKeyword("style:line-break")]
        public const string style_line_break = "style" + General.CONLON + "line-break";

        [XmlKeyword("style:tab-stop-distance")]
        public const string style_tab_stop_distance = "style" + General.CONLON + "tab-stop-distance";

        [XmlKeyword("style:font-independent-line-spacing")]
        public const string style_font_independent_line_spacing = "style" + General.CONLON + "font-independent-line-spacing";

        [XmlKeyword("style:tab-stops")]
        public const string style_tab_stops = "style" + General.CONLON + "tab-stops";

        [XmlKeyword("loext:contextual-spacing")]
        public const string loext_contextual_spacing = "loext" + General.CONLON + "contextual-spacing";

        [XmlKeyword("fo:keep-with-next")]
        public const string fo_keep_with_next = "fo" + General.CONLON + "keep-with-next";

        [XmlKeyword("fo:line-height")]
        public const string fo_line_height = "fo" + General.CONLON + "line-height";

        [XmlKeyword("text:number-lines")]
        public const string text_number_lines = "text" + General.CONLON + "number-lines";

        [XmlKeyword("text:line-number")]
        public const string text_line_number = "text" + General.CONLON + "line-number";




        [XmlKeyword("style:text-properties")]
        public const string style_text_properties = "style" + General.CONLON + "text-properties";

        [XmlKeyword("fo:color")]
        public const string fo_color = "fo" + General.CONLON + "color";

        [XmlKeyword("style:use-window-font-color")]
        public const string style_use_window_font_color = "style" + General.CONLON + "use-window-font-color";

        [XmlKeyword("style:font-name")]
        public const string style_font_name = "style" + General.CONLON + "font-name";

        [XmlKeyword("fo:font-family")]
        public const string fo_font_family = "fo" + General.CONLON + "font-family";

        [XmlKeyword("style:text-line-through-style")]
        public const string style_text_line_through_style = "style" + General.CONLON + "text-line-through-style";

        [XmlKeyword("style:text-line-through-type")]
        public const string style_text_line_through_type = "style" + General.CONLON + "text-line-through-type";

        [XmlKeyword("fo:font-size")]
        public const string fo_font_size = "fo" + General.CONLON + "font-size";

        [XmlKeyword("fo:font-style")]
        public const string fo_font_style = "fo" + General.CONLON + "font-style";

        [XmlKeyword("style:text-underline-style")]
        public const string style_text_underline_style = "style" + General.CONLON + "text-underline-style";

        [XmlKeyword("style:text-underline-width")]
        public const string style_text_underline_width = "style" + General.CONLON + "text-underline-width";

        [XmlKeyword("style:text-underline-color")]
        public const string style_text_underline_color = "style" + General.CONLON + "text-underline-color";

        [XmlKeyword("fo:font-weight")]
        public const string fo_font_weight = "fo" + General.CONLON + "font-weight";

        [XmlKeyword("fo:background-color")]
        public const string fo_background_color = "fo" + General.CONLON + "background-color";

        [XmlKeyword("fo:language")]
        public const string fo_language = "fo" + General.CONLON + "language";

        [XmlKeyword("fo:country")]
        public const string fo_country = "fo" + General.CONLON + "country";

        [XmlKeyword("officeooo:rsid")]
        public const string officeooo_rsid = "officeooo" + General.CONLON + "rsid";

        [XmlKeyword("officeooo:paragraph-rsid")]
        public const string officeooo_paragraph_rsid = "officeooo" + General.CONLON + "paragraph-rsid";

        //[XmlKeyword("style:font-family-generic")]
        //public const string style_font_family_generic = "style" + General.CONLON + "font-family-generic";

        //[XmlKeyword("style:font-pitch")]
        //public const string style_font_pitch = "style" + General.CONLON + "font-pitch";

        [XmlKeyword("style:letter-kerning")]
        public const string style_letter_kerning = "style" + General.CONLON + "letter-kerning";

        [XmlKeyword("style:font-name-asian")]
        public const string style_font_name_asian = "style" + General.CONLON + "font-name-asian";

        [XmlKeyword("style:font-family-asian")]
        public const string style_font_family_asian = "style" + General.CONLON + "font-family-asian";

        [XmlKeyword("style:font-family-generic-asian")]
        public const string style_font_family_generic_asian = "style" + General.CONLON + "font-family-generic-asian";

        [XmlKeyword("style:font-pitch-asian")]
        public const string style_font_pitch_asian = "style" + General.CONLON + "font-pitch-asian";

        [XmlKeyword("style:font-size-asian")]
        public const string style_font_size_asian = "style" + General.CONLON + "font-size-asian";

        [XmlKeyword("style:font-weight-asian")]
        public const string style_font_weight_asian = "style" + General.CONLON + "font-weight-asian";

        [XmlKeyword("style:font-style-asian")]
        public const string style_font_style_asian = "style" + General.CONLON + "font-style-asian";

        [XmlKeyword("style:language-asian")]
        public const string style_language_asian = "style" + General.CONLON + "language-asian";

        [XmlKeyword("style:country-asian")]
        public const string style_country_asian = "style" + General.CONLON + "country-asian";

        [XmlKeyword("style:font-name-complex")]
        public const string style_font_name_complex = "style" + General.CONLON + "font-name-complex";

        [XmlKeyword("style:font-family-complex")]
        public const string style_font_family_complex = "style" + General.CONLON + "font-family-complex";

        [XmlKeyword("style:font-family-generic-complex")]
        public const string style_font_family_generic_complex = "style" + General.CONLON + "font-family-generic-complex";

        [XmlKeyword("style:font-pitch-complex")]
        public const string style_font_pitch_complex = "style" + General.CONLON + "font-pitch-complex";

        [XmlKeyword("style:font-size-complex")]
        public const string style_font_size_complex = "style" + General.CONLON + "font-size-complex";

        [XmlKeyword("style:font-weight-complex")]
        public const string style_font_weight_complex = "style" + General.CONLON + "font-weight-complex";

        [XmlKeyword("style:font-style-complex")]
        public const string style_font_style_complex = "style" + General.CONLON + "font-style-complex";

        [XmlKeyword("style:language-complex")]
        public const string style_language_complex = "style" + General.CONLON + "language-complex";

        [XmlKeyword("style:country-complex")]
        public const string style_country_complex = "style" + General.CONLON + "country-complex";

        [XmlKeyword("fo:hyphenate")]
        public const string fo_hyphenate = "fo" + General.CONLON + "hyphenate";

        [XmlKeyword("fo:hyphenation-remain-char-count")]
        public const string fo_hyphenation_remain_char_count = "fo" + General.CONLON + "hyphenation-remain-char-count";

        [XmlKeyword("fo:hyphenation-push-char-count")]
        public const string fo_hyphenation_push_char_count = "fo" + General.CONLON + "hyphenation-push-char-count";




        [XmlKeyword("style:table-properties")]
        public const string style_table_properties = "style" + General.CONLON + "table-properties";

        [XmlKeyword("table:border-model")]
        public const string table_border_model = "table" + General.CONLON + "border-model";

        [XmlKeyword("table:align")]
        public const string table_align = "table" + General.CONLON + "align";




        [XmlKeyword("style:table-row-properties")]
        public const string style_table_row_properties = "style" + General.CONLON + "table-row-properties";

        [XmlKeyword("fo:keep-together")]
        public const string fo_keep_together = "fo" + General.CONLON + "keep-together";




        [XmlKeyword("style:table-column-properties")]
        public const string style_table_column_properties = "style" + General.CONLON + "table-column-properties";

        [XmlKeyword("style:column-width")]
        public const string style_column_width = "style" + General.CONLON + "column-width";

        [XmlKeyword("style:rel-column-width")]
        public const string style_rel_column_width = "style" + General.CONLON + "rel-column-width";





        [XmlKeyword("style:table-cell-properties")]
        public const string style_table_cell_properties = "style" + General.CONLON + "table-cell-properties";

        [XmlKeyword("fo:padding")]
        public const string fo_padding = "fo" + General.CONLON + "padding";

        [XmlKeyword("fo:border-left")]
        public const string fo_border_left = "fo" + General.CONLON + "border-left";

        [XmlKeyword("fo:border-right")]
        public const string fo_border_right = "fo" + General.CONLON + "border-right";

        [XmlKeyword("fo:border-top")]
        public const string fo_border_top = "fo" + General.CONLON + "border-top";

        [XmlKeyword("fo:border-bottom")]
        public const string fo_border_bottom = "fo" + General.CONLON + "border-bottom";

        [XmlKeyword("fo:border")]
        public const string fo_border = "fo" + General.CONLON + "border";



        [XmlKeyword("table:table")]
        public const string table_table = "table" + General.CONLON + "table";

        [XmlKeyword("table:name")]
        public const string table_name = "table" + General.CONLON + "name";

        [XmlKeyword("table:style-name")]
        public const string table_style_name = "table" + General.CONLON + "style-name";




        [XmlKeyword("table:table-column")]
        public const string table_table_column = "table" + General.CONLON + "table-column";




        [XmlKeyword("table:table-row")]
        public const string table_table_row = "table" + General.CONLON + "table-row";




        [XmlKeyword("table:table-cell")]
        public const string table_table_cell = "table" + General.CONLON + "table-cell";

        [XmlKeyword("office:value-type")]
        public const string office_value_type = "office" + General.CONLON + "value-type";

        [XmlKeyword("table:number-columns-spanned")]
        public const string table_number_columns_spanned = "table" + General.CONLON + "number-columns-spanned";

        [XmlKeyword("table:number-rows-spanned")]
        public const string table_number_rows_spanned = "table" + General.CONLON + "number-rows-spanned";




        [XmlKeyword("table:covered-table-cell")]
        public const string table_covered_table_cell = "table" + General.CONLON + "covered-table-cell";




        [XmlKeyword("text:p")]
        public const string text_p = "text" + General.CONLON + "p";

        [XmlKeyword("text:style-name")]
        public const string text_style_name = "text" + General.CONLON + "style-name";



        [XmlKeyword("draw:frame")]
        public const string draw_frame = "draw" + General.CONLON + "frame";

        [XmlKeyword("draw:style-name")]
        public const string draw_style_name = "draw" + General.CONLON + "style-name";

        [XmlKeyword("draw:name")]
        public const string draw_name = "draw" + General.CONLON + "name";

        [XmlKeyword("text:anchor-type")]
        public const string text_anchor_type = "text" + General.CONLON + "anchor-type";

        [XmlKeyword("svg:width")]
        public const string svg_width = "svg" + General.CONLON + "width";

        [XmlKeyword("svg:height")]
        public const string svg_height = "svg" + General.CONLON + "height";

        [XmlKeyword("draw:z-index")]
        public const string draw_z_index = "draw" + General.CONLON + "z-index";


        [XmlKeyword("draw:image")]
        public const string draw_image = "draw" + General.CONLON + "image";

        [XmlKeyword("xlink:href")]
        public const string xlink_href = "xlink" + General.CONLON + "href";

        [XmlKeyword("xlink:type")]
        public const string xlink_type = "xlink" + General.CONLON + "type";

        [XmlKeyword("xlink:show")]
        public const string xlink_show = "xlink" + General.CONLON + "show";

        [XmlKeyword("xlink:actuate")]
        public const string xlink_actuate = "xlink" + General.CONLON + "actuate";

        [XmlKeyword("loext:mime-type")]
        public const string loext_mime_type = "loext" + General.CONLON + "mime-type";





        [XmlKeyword("style:graphic-properties")]
        public const string style_graphic_properties = "style" + General.CONLON + "graphic-properties";

        [XmlKeyword("svg:stroke-color")]
        public const string svg_stroke_color = "svg" + General.CONLON + "stroke-color";

        [XmlKeyword("draw:fill-color")]
        public const string draw_fill_color = "draw" + General.CONLON + "fill-color";

        [XmlKeyword("fo:wrap-option")]
        public const string fo_wrap_option = "fo" + General.CONLON + "wrap-option";

        [XmlKeyword("draw:shadow-offset-x")]
        public const string draw_shadow_offset_x = "draw" + General.CONLON + "shadow-offset-x";

        [XmlKeyword("draw:shadow-offset-y")]
        public const string draw_shadow_offset_y = "draw" + General.CONLON + "shadow-offset-y";

        [XmlKeyword("draw:start-line-spacing-horizontal")]
        public const string draw_start_line_spacing_horizontal = "draw" + General.CONLON + "start-line-spacing-horizontal";

        [XmlKeyword("draw:start-line-spacing-vertical")]
        public const string draw_start_line_spacing_vertical = "draw" + General.CONLON + "start-line-spacing-vertical";

        [XmlKeyword("draw:end-line-spacing-horizontal")]
        public const string draw_end_line_spacing_horizontal = "draw" + General.CONLON + "end-line-spacing-horizontal";

        [XmlKeyword("draw:end-line-spacing-vertical")]
        public const string draw_end_line_spacing_vertical = "draw" + General.CONLON + "end-line-spacing-vertical";

        [XmlKeyword("style:flow-with-text")]
        public const string style_flow_with_text = "style" + General.CONLON + "flow-with-text";

        [XmlKeyword("style:run-through")]
        public const string style_run_through = "style" + General.CONLON + "run-through";

        [XmlKeyword("svg:x")]
        public const string svg_x = "svg" + General.CONLON + "x";

        [XmlKeyword("svg:y")]
        public const string svg_y = "svg" + General.CONLON + "y";

        [XmlKeyword("style:wrap")]
        public const string style_wrap = "style" + General.CONLON + "wrap";

        [XmlKeyword("style:number-wrapped-paragraphs")]
        public const string style_number_wrapped_paragraphs = "style" + General.CONLON + "number-wrapped-paragraphs";

        [XmlKeyword("style:wrap-contour")]
        public const string style_wrap_contour = "style" + General.CONLON + "wrap-contour";

        [XmlKeyword("style:vertical-pos")]
        public const string style_vertical_pos = "style" + General.CONLON + "vertical-pos";

        [XmlKeyword("style:vertical-rel")]
        public const string style_vertical_rel = "style" + General.CONLON + "vertical-rel";

        [XmlKeyword("style:horizontal-pos")]
        public const string style_horizontal_pos = "style" + General.CONLON + "horizontal-pos";

        [XmlKeyword("style:horizontal-rel")]
        public const string style_horizontal_rel = "style" + General.CONLON + "horizontal-rel";

        [XmlKeyword("style:mirror")]
        public const string style_mirror = "style" + General.CONLON + "mirror";

        [XmlKeyword("fo:clip")]
        public const string fo_clip = "fo" + General.CONLON + "clip";

        [XmlKeyword("draw:luminance")]
        public const string draw_luminance = "draw" + General.CONLON + "luminance";

        [XmlKeyword("draw:contrast")]
        public const string draw_contrast = "draw" + General.CONLON + "contrast";

        [XmlKeyword("draw:red")]
        public const string draw_red = "draw" + General.CONLON + "red";

        [XmlKeyword("draw:green")]
        public const string draw_green = "draw" + General.CONLON + "green";

        [XmlKeyword("draw:blue")]
        public const string draw_blue = "draw" + General.CONLON + "blue";

        [XmlKeyword("draw:gamma")]
        public const string draw_gamma = "draw" + General.CONLON + "gamma";

        [XmlKeyword("draw:color-inversion")]
        public const string draw_color_inversion = "draw" + General.CONLON + "color-inversion";

        [XmlKeyword("draw:image-opacity")]
        public const string draw_image_opacity = "draw" + General.CONLON + "image-opacity";

        [XmlKeyword("draw:color-mode")]
        public const string draw_color_mode = "draw" + General.CONLON + "color-mode";
    }
}
