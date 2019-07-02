using JOD.Utils;
using JOD.Writer.Models.com;
using JOD.Writer.Models.manifest;
using JOD.Writer.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.content
{
    [XmlType(ContentKeyword.office_document_content)]
    public class OfficeDocumentContent
    {
        [XmlAttribute(ContentKeyword.xmlns_office)]
        public string xmlns_office { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_style)]
        public string xmlns_style { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_text)]
        public string xmlns_text { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_table)]
        public string xmlns_table { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_draw)]
        public string xmlns_draw { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_fo)]
        public string xmlns_fo { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_xlink)]
        public string xmlns_xlink { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_dc)]
        public string xmlns_dc { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_meta)]
        public string xmlns_meta { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_number)]
        public string xmlns_number { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_svg)]
        public string xmlns_svg { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_chart)]
        public string xmlns_chart { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_dr3d)]
        public string xmlns_dr3d { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_math)]
        public string xmlns_math { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_form)]
        public string xmlns_form { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_script)]
        public string xmlns_script { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_ooo)]
        public string xmlns_ooo { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_ooow)]
        public string xmlns_ooow { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_oooc)]
        public string xmlns_oooc { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_dom)]
        public string xmlns_dom { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_xforms)]
        public string xmlns_xforms { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_xsd)]
        public string xmlns_xsd { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_xsi)]
        public string xmlns_xsi { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_rpt)]
        public string xmlns_rpt { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_of)]
        public string xmlns_of { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_xhtml)]
        public string xmlns_xhtml { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_grddl)]
        public string xmlns_grddl { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_officeooo)]
        public string xmlns_officeooo { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_tableooo)]
        public string xmlns_tableooo { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_drawooo)]
        public string xmlns_drawooo { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_calcext)]
        public string xmlns_calcext { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_loext)]
        public string xmlns_loext { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_field)]
        public string xmlns_field { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_formx)]
        public string xmlns_formx { get; set; }

        [XmlAttribute(ContentKeyword.xmlns_css3t)]
        public string xmlns_css3t { get; set; }

        [XmlAttribute(ContentKeyword.office_version)]
        public double office_version { get; set; }





        [XmlElement(ContentKeyword.office_scripts)]
        public OfficeScripts office_scripts { get; set; }

        [XmlElement(ContentKeyword.office_font_face_decls)]
        public OfficeFontFaceDecls office_font_face_decls { get; set; }

        [XmlElement(ContentKeyword.office_automatic_styles)]
        public OfficeAutomaticStyles office_automatic_styles { get; set; }

        [XmlElement(ContentKeyword.office_body)]
        public OfficeBody office_body { get; set; }

        /// <summary>
        /// 段落的编号
        /// </summary>
        [XmlIgnore]
        private int _indexParagraph = 0;

        /// <summary>
        /// 表格的编号
        /// </summary>
        [XmlIgnore]
        private int _indexTable = 0;

        /// <summary>
        /// frame的编号
        /// </summary>
        [XmlIgnore]
        private int _indexFrame = 0;

        public OfficeDocumentContent()
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
            xmlns_xforms = Constant.xmlns_xforms;
            xmlns_xsd = Constant.xmlns_xsd;
            xmlns_xsi = Constant.xmlns_xsi;
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
            xmlns_formx = Constant.xmlns_formx;
            xmlns_css3t = Constant.xmlns_css3t;
            office_version = Constant.office_version;



            office_scripts = new OfficeScripts();
            office_font_face_decls = new OfficeFontFaceDecls();
            office_font_face_decls.CreateIni();
            office_automatic_styles = new OfficeAutomaticStyles();
            office_body = new OfficeBody();
        }

        public void SetElements(List<Element> elemList, double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight, PartManifest pmanifest)
        {
            var elementList = office_body.office_text.text_element;
            var styleList = new List<StyleStyle>();
            office_automatic_styles.style_style = styleList;
            elementList.Clear();
            styleList.Clear();
            if (elemList != null && elemList.Count > 0)
            {
                foreach (var item in elemList)
                {
                    if (item is Paragraph)
                    {
                        Paragraph para = item as Paragraph;
                        CreateParagraph(elementList, styleList, para);
                    }
                    else if (item is Table)
                    {
                        Table table = item as Table;
                        CreateTable(elementList, styleList, table, width, height, marginTop, marginBottom, marginLeft, marginRight,pmanifest);
                    }
                }
            }
        }

        private void CreateParagraph(List<TextElement> elementList, List<StyleStyle> styleList, Paragraph para)
        {
            _indexParagraph++;
            string styleName = "P" + _indexParagraph;
            StyleStyle style = new StyleStyle();
            style.style_name = styleName;
            style.style_family = "paragraph";
            style.style_parent_style_name = "Standard";
            var pp = new StyleParagraphProperties();
            pp.fo_text_align_忽略 = para.TextAlign;
            pp.style_justify_single_word_忽略 = false;
            style.style_paragraph_properties = pp;

            var tp = new StyleTextProperties();
            tp.fo_color = para.Color;
            tp.style_text_line_through_style_忽略 = para.TextLineThroughStyle;
            tp.style_text_line_through_type_忽略 = para.TextLineThroughType;
            tp.fo_font_size_忽略 = para.FontSize;
            tp.fo_font_style_忽略 = para.FtStyle;
            tp.style_text_underline_style_忽略 = para.TextUnderlineStyle;
            tp.style_text_underline_width = "auto";
            tp.style_text_underline_color = "font-color";
            tp.fo_font_weight_忽略 = para.FontWeight;
            tp.fo_background_color = para.BackgroudColor;
            tp.style_font_name_asian = para.FontName;
            tp.style_font_size_asian_忽略 = para.FontSize;
            tp.style_font_style_asian_忽略 = para.FtStyle;
            tp.style_font_weight_asian_忽略 = para.FontWeight;
            tp.style_font_size_complex_忽略 = para.FontSize;
            tp.style_font_style_complex_忽略 = para.FtStyle;
            tp.style_font_weight_complex_忽略 = para.FontWeight;
            style.style_text_properties = tp;
            styleList.Add(style);

            TextP textp = new TextP();
            textp.text = para.Text;
            textp.text_style_name = styleName;
            elementList.Add(textp);
        }

        private void CreateTable(List<TextElement> elementList, List<StyleStyle> styleList, Table table, double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight, PartManifest pmanifest)
        {
            _indexTable++;
            string styleName = "表格" + _indexTable;

            StyleStyle style = new StyleStyle();
            style.style_name = styleName;
            style.style_family = "table";

            var st = new StyleTableProperties();
            //表格宽度
            double width_tmp = 0;
            if (table.Width <= 0)
            {
                width_tmp = width - marginLeft - marginRight;
            }
            else
            {
                width_tmp = table.Width;
            }
            st.style_width_忽略 = width_tmp;
            st.table_align = "margins";
            style.style_table_properties = st;
            styleList.Add(style);

            //表格
            TableTable tt = new TableTable();
            tt.table_name = styleName;
            tt.table_style_name = styleName;
            tt.table_table_column = new List<TableTableColumn>();
            tt.table_table_row = new List<TableTableRow>();
            elementList.Add(tt);


            List<int> tableColumnList = table._columnList;
            int allColumnProportion = 0;
            foreach (var item in tableColumnList)
            {
                allColumnProportion += item;
            }

            int indexColumn = 0;
            foreach (var item in tableColumnList)
            {
                indexColumn++;
                string columnStyleName = styleName + "." + LetterHelper.GetLetter(indexColumn);
                StyleStyle styleColumn = new StyleStyle();
                styleColumn.style_name = columnStyleName;
                styleColumn.style_family = "table-column";
                var stcp = new StyleTableColumnProperties();
                var columnWidth = width_tmp * item / allColumnProportion;
                stcp.style_column_width_忽略 = columnWidth;
                stcp.style_rel_column_width = !stcp.style_column_width_忽略.HasValue ? "0*" : CmRelHelper.CmToRel(stcp.style_column_width_忽略.Value) + "*";
                styleColumn.style_table_column_properties = stcp;
                styleList.Add(styleColumn);

                //列
                TableTableColumn ttc = new TableTableColumn();
                ttc.table_style_name = columnStyleName;
                tt.table_table_column.Add(ttc);
            }

            List<Cell> cellList = table._cellList;
            int[,] array = CreateArray(tableColumnList.Count, cellList);
            //int indexCell = 0;
            //foreach (var item in cellList)
            //{
            //    indexCell++;
            //    string cellStyleName = styleName + "." + LetterHelper.GetLetter(indexCell) + "1";
            //    StyleStyle styleCell = new StyleStyle();
            //    styleCell.style_name = cellStyleName;
            //    styleCell.style_family = "table-cell";
            //    var stcp = new StyleTableCellProperties();
            //    stcp.fo_padding = "0cm";
            //    stcp.fo_border = "0.05pt solid #000000";
            //    styleCell.style_table_cell_properties = stcp;
            //    styleList.Add(styleCell);
            //}

            int k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                TableTableRow row = new TableTableRow();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int info = array[i, j];
                    if(info == 1)
                    {
                        k++;
                        Cell cell = cellList[k - 1];

                        string cellStyleName = styleName + "." + LetterHelper.GetLetter(k) + "1";
                        StyleStyle styleCell = new StyleStyle();
                        styleCell.style_name = cellStyleName;
                        styleCell.style_family = "table-cell";
                        var stcp = new StyleTableCellProperties();
                        stcp.fo_padding = "0cm";
                        stcp.fo_border = "0.05pt solid #000000";
                        stcp.fo_padding = cell.padding + "cm";
                        styleCell.style_table_cell_properties = stcp;
                        styleList.Add(styleCell);

                        TableTableCell ttCell = new TableTableCell();
                        ttCell.table_style_name = cellStyleName;
                        ttCell.office_value_type = "string";
                        if(cell.ColumnsSpanned > 1)
                        {
                            ttCell.table_number_columns_spanned = cell.ColumnsSpanned.ToString();
                        }
                        if(cell.RowsSpanned > 1)
                        {
                            ttCell.table_number_rows_spanned = cell.RowsSpanned.ToString();
                        }

                        string textStyle = CreateTextPStyle(styleList, cell.fStyle);

                        if (cell.isImage)
                        {
                            string frStyle = CreateGraphicsStyle(styleList);

                            TextP tp = new TextP();
                            tp.text_style_name = textStyle;
                            var drawFrame = new DrawFrame();
                            drawFrame.draw_style_name = frStyle;
                            drawFrame.draw_name = "图像" + _indexFrame;
                            drawFrame.text_anchor_type = "as-char";
                            drawFrame.svg_width_忽略 = cell.imgWidth;
                            drawFrame.svg_height_忽略 = cell.imgHeight;
                            drawFrame.draw_z_index = "0";
                            DrawImage dimg = new DrawImage();
                            string newImagePath = "";
                            if(cell.bitmap != null)
                            {
                                newImagePath = PartPicture.CreatPictule(cell.bitmap);
                            }
                            else
                            {
                                newImagePath = PartPicture.CreatPictule(cell.imgPath);
                            }                            

                            FileEntry file = new FileEntry();
                            file.FullPath = newImagePath;
                            file.MediaType = "image/jpeg";
                            pmanifest.AddFileEntry(file);

                            dimg.xlink_href = newImagePath;////
                            dimg.xlink_type = "simple";
                            dimg.xlink_show = "embed";
                            dimg.xlink_actuate = "onLoad";
                            dimg.loext_mime_type = "image/jpeg";

                            drawFrame.draw_image = dimg;


                            tp.draw_frame = drawFrame;

                            ttCell.text_p = tp;
                        }
                        else
                        {
                            TextP tp = new TextP();
                            tp.text = cell.Text;
                            tp.text_style_name = textStyle;
                            ttCell.text_p = tp;
                        }
                        row.table_cell_element.Add(ttCell);
                    }
                    else
                    {
                        TableCoveredTableCell tctCell = new TableCoveredTableCell();
                        row.table_cell_element.Add(tctCell);
                    }
                }

                tt.table_table_row.Add(row);
            }
        }

        /// <summary>
        /// 创建二维数组
        /// </summary>
        /// <param name="column"></param>
        /// <param name="cellList"></param>
        /// <returns></returns>
        private int[,] CreateArray(int column, List<Cell> cellList)
        {
            int count = 0;
            foreach (var item in cellList)
            {
                var num = item.ColumnsSpanned * item.RowsSpanned;
                count += num;
            }
            int row = count / column;
            int k = count % column;
            if (k > 0)
            {
                row++;
            }

            //0：空 1:有元素 9:跨越元素(不能再占据)
            int[,] table = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    table[i, j] = 0;
                }
            }
            for (int i = 0; i < cellList.Count; i++)
            {
                int row_tmp = 0;
                int column_tmp = 0;
                if (getArray(table, out row_tmp, out column_tmp))
                {
                    var cell = cellList[i];
                    for (int m = 0; m < cell.RowsSpanned; m++)
                    {
                        for (int n = 0; n < cell.ColumnsSpanned; n++)
                        {
                            if (m == 0 && n == 0)
                            {
                                table[row_tmp, column_tmp] = 1;
                            }
                            else
                            {
                                table[row_tmp + m, column_tmp + n] = 9;
                            }
                        }
                    }
                }
            }
            return table;
        }

        private bool getArray(int[,] array, out int row, out int column)
        {
            bool isok = false;
            row = 0;
            column = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool isBreak = false;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        row = i;
                        column = j;
                        isok = true;
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak)
                {
                    break;
                }
            }
            return isok;
        }

        public string CreateTextPStyle(List<StyleStyle> styleList,FtStyle param)
        {
            FtStyle fs = param;
            if (fs == null)
            {
                fs = new FtStyle();
            }
            _indexParagraph++;
            string styleName = "P" + _indexParagraph;
            StyleStyle style = new StyleStyle();
            style.style_name = styleName;
            style.style_family = "paragraph";
            style.style_parent_style_name = "Table_20_Contents";
            var pp = new StyleParagraphProperties();
            pp.fo_text_align_忽略 = fs.TextAlign;
            pp.style_justify_single_word_忽略 = false;
            style.style_paragraph_properties = pp;

            var tp = new StyleTextProperties();
            tp.fo_color = fs.Color;
            tp.style_text_line_through_style_忽略 = fs.TextLineThroughStyle;
            tp.style_text_line_through_type_忽略 = fs.TextLineThroughType;
            tp.fo_font_size_忽略 = fs.FontSize;
            tp.fo_font_style_忽略 = fs.FStyle;
            tp.style_text_underline_style_忽略 = fs.TextUnderlineStyle;
            tp.style_text_underline_width = "auto";
            tp.style_text_underline_color = "font-color";
            tp.fo_font_weight_忽略 = fs.FontWeight;
            tp.fo_background_color = fs.BackgroudColor;
            tp.style_font_name_asian = fs.FontName;
            tp.style_font_size_asian_忽略 = fs.FontSize;
            tp.style_font_style_asian_忽略 = fs.FStyle;
            tp.style_font_weight_asian_忽略 = fs.FontWeight;
            tp.style_font_size_complex_忽略 = fs.FontSize;
            tp.style_font_style_complex_忽略 = fs.FStyle;
            tp.style_font_weight_complex_忽略 = fs.FontWeight;
            style.style_text_properties = tp;
            styleList.Add(style);
            return styleName;
        }


        public string CreateGraphicsStyle(List<StyleStyle> styleList)
        {
            _indexFrame++;
            string styleName = "fr" + _indexFrame;
            StyleStyle style = new StyleStyle();
            style.style_name = styleName;
            style.style_family = "graphic";
            style.style_parent_style_name = "Graphics";
            var sgp = new StyleGraphicProperties();
            sgp.style_run_through = "foreground";
            sgp.style_wrap = "dynamic";
            sgp.style_number_wrapped_paragraphs = "no-limit";
            sgp.style_wrap_contour = "false";
            sgp.style_vertical_pos = "top";
            sgp.style_vertical_rel = "baseline";
            sgp.style_horizontal_pos = "center";
            sgp.style_horizontal_rel = "paragraph";
            sgp.style_mirror = "none";
            sgp.fo_clip = "rect(0cm, 0cm, 0cm, 0cm)";
            sgp.draw_luminance = "0%";
            sgp.draw_contrast = "0%";
            sgp.draw_red = "0%";
            sgp.draw_green = "0%";
            sgp.draw_blue = "0%";
            sgp.draw_gamma = "100%";
            sgp.draw_color_inversion = "false";
            sgp.draw_image_opacity = "100%";
            sgp.draw_color_mode = "standard";

            style.style_graphic_properties = sgp;

            styleList.Add(style);
            return styleName;
        }
    }
}
