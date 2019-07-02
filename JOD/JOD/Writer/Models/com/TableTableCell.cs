using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class TableTableCell : TableCellBase
    {
        [XmlAttribute(WriterKeyword.table_style_name)]
        public string table_style_name { get; set; }

        [XmlAttribute(WriterKeyword.table_number_columns_spanned)]
        public string table_number_columns_spanned { get; set; }

        [XmlAttribute(WriterKeyword.table_number_rows_spanned)]
        public string table_number_rows_spanned { get; set; }

        [XmlAttribute(WriterKeyword.office_value_type)]
        public string office_value_type { get; set; }

        [XmlElement(WriterKeyword.text_p)]
        public TextP text_p { get; set; }
    }
}
