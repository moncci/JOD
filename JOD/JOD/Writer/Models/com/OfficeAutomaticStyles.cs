using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    /// <summary>
    /// 自动样式
    /// </summary>
    public class OfficeAutomaticStyles
    {
        [XmlElement(WriterKeyword.style_page_layout)]
        public StylePageLayout style_page_layout { get; set; }

        [XmlElement(WriterKeyword.style_style)]
        public List<StyleStyle> style_style { get; set; }

        public OfficeAutomaticStyles()
        {

        }

        public void CreateIni()
        {
            style_page_layout = new StylePageLayout()
            {
                style_name = "Mpm1",
                style_page_layout_properties = new StylePageLayoutProperties()
                {
                    fo_page_width = "8.5in",
                    fo_page_height = "11in",
                    style_num_format = "1",
                    style_print_orientation = "portrait",
                    fo_margin_top = "0.7874in",
                    fo_margin_bottom = "0.7874in",
                    fo_margin_left = "0.7874in",
                    fo_margin_right = "0.7874in",
                    style_writing_mode = "lr-tb",
                    style_footnote_max_height = "0in",
                    style_footnote_sep = new StyleFootnoteSep()
                    {
                        style_width = "0.0071in",
                        style_distance_before_sep = "0.0398in",
                        style_distance_after_sep = "0.0398in",
                        style_line_style = "solid",
                        style_adjustment = "left",
                        style_rel_width = "25%",
                        style_color = "#000000"
                    }
                },
                style_header_style = new StyleHeaderStyle(),
                style_footer_style = new StyleFooterStyle()
            };
        }
    }
}
