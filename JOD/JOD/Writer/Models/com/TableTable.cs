using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class TableTable : TextElement
    {
        [XmlAttribute(WriterKeyword.table_name)]
        public string table_name { get; set; }

        [XmlAttribute(WriterKeyword.table_style_name)]
        public string table_style_name { get; set; }

        [XmlElement(WriterKeyword.table_table_column)]
        public List<TableTableColumn> table_table_column { get; set; }

        [XmlElement(WriterKeyword.table_table_row)]
        public List<TableTableRow> table_table_row { get; set; }
    }
}
