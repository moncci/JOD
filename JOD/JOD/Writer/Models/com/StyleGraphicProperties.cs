using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleGraphicProperties
    {
        [XmlAttribute(WriterKeyword.svg_stroke_color)]
        public string svg_stroke_color { get; set; }

        [XmlAttribute(WriterKeyword.draw_fill_color)]
        public string draw_fill_color { get; set; }

        [XmlAttribute(WriterKeyword.fo_wrap_option)]
        public string fo_wrap_option { get; set; }

        [XmlAttribute(WriterKeyword.draw_shadow_offset_x)]
        public string draw_shadow_offset_x { get; set; }

        [XmlAttribute(WriterKeyword.draw_shadow_offset_y)]
        public string draw_shadow_offset_y { get; set; }

        [XmlAttribute(WriterKeyword.draw_start_line_spacing_horizontal)]
        public string draw_start_line_spacing_horizontal { get; set; }

        [XmlAttribute(WriterKeyword.draw_start_line_spacing_vertical)]
        public string draw_start_line_spacing_vertical { get; set; }

        [XmlAttribute(WriterKeyword.draw_end_line_spacing_horizontal)]
        public string draw_end_line_spacing_horizontal { get; set; }

        [XmlAttribute(WriterKeyword.draw_end_line_spacing_vertical)]
        public string draw_end_line_spacing_vertical { get; set; }

        [XmlAttribute(WriterKeyword.style_flow_with_text)]
        public string style_flow_with_text { get; set; }

        [XmlAttribute(WriterKeyword.style_run_through)]
        public string style_run_through { get; set; }

        [XmlAttribute(WriterKeyword.text_anchor_type)]
        public string text_anchor_type { get; set; }

        [XmlAttribute(WriterKeyword.svg_x)]
        public string svg_x { get; set; }

        [XmlAttribute(WriterKeyword.svg_y)]
        public string svg_y { get; set; }

        [XmlAttribute(WriterKeyword.style_wrap)]
        public string style_wrap { get; set; }

        [XmlAttribute(WriterKeyword.style_number_wrapped_paragraphs)]
        public string style_number_wrapped_paragraphs { get; set; }

        [XmlAttribute(WriterKeyword.style_wrap_contour)]
        public string style_wrap_contour { get; set; }

        [XmlAttribute(WriterKeyword.style_vertical_pos)]
        public string style_vertical_pos { get; set; }

        [XmlAttribute(WriterKeyword.style_vertical_rel)]
        public string style_vertical_rel { get; set; }

        [XmlAttribute(WriterKeyword.style_horizontal_pos)]
        public string style_horizontal_pos { get; set; }

        [XmlAttribute(WriterKeyword.style_horizontal_rel)]
        public string style_horizontal_rel { get; set; }

        [XmlAttribute(WriterKeyword.style_mirror)]
        public string style_mirror { get; set; }

        [XmlAttribute(WriterKeyword.fo_clip)]
        public string fo_clip { get; set; }

        [XmlAttribute(WriterKeyword.draw_luminance)]
        public string draw_luminance { get; set; }

        [XmlAttribute(WriterKeyword.draw_contrast)]
        public string draw_contrast { get; set; }

        [XmlAttribute(WriterKeyword.draw_red)]
        public string draw_red { get; set; }

        [XmlAttribute(WriterKeyword.draw_green)]
        public string draw_green { get; set; }

        [XmlAttribute(WriterKeyword.draw_blue)]
        public string draw_blue { get; set; }

        [XmlAttribute(WriterKeyword.draw_gamma)]
        public string draw_gamma { get; set; }

        [XmlAttribute(WriterKeyword.draw_color_inversion)]
        public string draw_color_inversion { get; set; }

        [XmlAttribute(WriterKeyword.draw_image_opacity)]
        public string draw_image_opacity { get; set; }

        [XmlAttribute(WriterKeyword.draw_color_mode)]
        public string draw_color_mode { get; set; }
    }
}
