using JOD.Writer.Models.com;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    [XmlType(StyleKeyword.office_document_styles)]
    public class OfficeDocumentStyles
    {
        [XmlAttribute(StyleKeyword.xmlns_office)]
        public string xmlns_office { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_style)]
        public string xmlns_style { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_text)]
        public string xmlns_text { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_table)]
        public string xmlns_table { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_draw)]
        public string xmlns_draw { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_fo)]
        public string xmlns_fo { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_xlink)]
        public string xmlns_xlink { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_dc)]
        public string xmlns_dc { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_meta)]
        public string xmlns_meta { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_number)]
        public string xmlns_number { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_svg)]
        public string xmlns_svg { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_chart)]
        public string xmlns_chart { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_dr3d)]
        public string xmlns_dr3d { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_math)]
        public string xmlns_math { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_form)]
        public string xmlns_form { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_script)]
        public string xmlns_script { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_ooo)]
        public string xmlns_ooo { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_ooow)]
        public string xmlns_ooow { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_oooc)]
        public string xmlns_oooc { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_dom)]
        public string xmlns_dom { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_rpt)]
        public string xmlns_rpt { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_of)]
        public string xmlns_of { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_xhtml)]
        public string xmlns_xhtml { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_grddl)]
        public string xmlns_grddl { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_officeooo)]
        public string xmlns_officeooo { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_tableooo)]
        public string xmlns_tableooo { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_drawooo)]
        public string xmlns_drawooo { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_calcext)]
        public string xmlns_calcext { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_loext)]
        public string xmlns_loext { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_field)]
        public string xmlns_field { get; set; }

        [XmlAttribute(StyleKeyword.xmlns_css3t)]
        public string xmlns_css3t { get; set; }

        [XmlAttribute(StyleKeyword.office_version)]
        public double office_version { get; set; }





        [XmlElement(StyleKeyword.office_font_face_decls)]
        public OfficeFontFaceDecls office_font_face_decls { get; set; }

        [XmlElement(StyleKeyword.office_styles)]
        public OfficeStyles office_styles { get; set; }

        [XmlElement(StyleKeyword.office_automatic_styles)]
        public OfficeAutomaticStyles office_automatic_styles { get; set; }

        [XmlElement(StyleKeyword.office_master_styles)]
        public OfficeMasterStyles office_master_styles { get; set; }

        public OfficeDocumentStyles()
        {
            xmlns_office = Constant.xmlns_office;
            xmlns_style = Constant.xmlns_style;
            xmlns_text = Constant.xmlns_text;
            xmlns_table = Constant.xmlns_table;
            xmlns_draw = Constant.xmlns_draw;
            xmlns_fo = Constant.xmlns_fo;
            xmlns_xlink = Constant.xmlns_xlink;
            xmlns_dc = Constant.xmlns_dc;
            xmlns_meta = Constant.xmlns_meta;
            xmlns_number = Constant.xmlns_number;
            xmlns_svg = Constant.xmlns_svg;
            xmlns_chart = Constant.xmlns_chart;
            xmlns_dr3d = Constant.xmlns_dr3d;
            xmlns_math = Constant.xmlns_math;
            xmlns_form = Constant.xmlns_form;
            xmlns_script = Constant.xmlns_script;
            xmlns_ooo = Constant.xmlns_ooo;
            xmlns_ooow = Constant.xmlns_ooow;
            xmlns_oooc = Constant.xmlns_oooc;
            xmlns_dom = Constant.xmlns_dom;
            xmlns_rpt = Constant.xmlns_rpt;
            xmlns_of = Constant.xmlns_of;
            xmlns_xhtml = Constant.xmlns_xhtml;
            xmlns_grddl = Constant.xmlns_grddl;
            xmlns_officeooo = Constant.xmlns_officeooo;
            xmlns_tableooo = Constant.xmlns_tableooo;
            xmlns_drawooo = Constant.xmlns_drawooo;
            xmlns_calcext = Constant.xmlns_calcext;
            xmlns_loext = Constant.xmlns_loext;
            xmlns_field = Constant.xmlns_field;
            xmlns_css3t = Constant.xmlns_css3t;
            office_version = Constant.office_version;


            office_font_face_decls = new OfficeFontFaceDecls();
            office_font_face_decls.CreateIni();


            office_styles = new OfficeStyles();
            office_styles.CreateIni_style_default_style();
            office_styles.CreateIni_style_style();
            office_styles.CreateIni_text_outline_style();
            office_styles.CreateIni_text_notes_configuration();
            office_styles.CreateIni_text_linenumbering_configuration();

            office_automatic_styles = new OfficeAutomaticStyles();
            office_automatic_styles.CreateIni();

            office_master_styles = new OfficeMasterStyles();
        }

        public void SetPaperSize(double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight)
        {
            var page = office_automatic_styles.style_page_layout.style_page_layout_properties;
            page.fo_page_width_忽略 = width;
            page.fo_page_height_忽略 = height;
            page.fo_margin_top_忽略 = marginTop;
            page.fo_margin_bottom_忽略 = marginBottom;
            page.fo_margin_left_忽略 = marginLeft;
            page.fo_margin_right_忽略 = marginRight;
            page.style_print_orientation = "portrait";
        }
    }
}
