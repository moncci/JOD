using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    [XmlInclude(typeof(TableTableCell))]
    [XmlInclude(typeof(TableCoveredTableCell))]
    public class TableTableRow
    {
        //[XmlElement(WriterKeyword.table_table_cell)]
        //public TableTableCell table_table_cell { get; set; }

        //[XmlElement(WriterKeyword.table_covered_table_cell)]
        //public TableCoveredTableCell table_covered_table_cell { get; set; }

        [XmlElement(Type = typeof(TableTableCell), ElementName = WriterKeyword.table_table_cell)]
        [XmlElement(Type = typeof(TableCoveredTableCell), ElementName = WriterKeyword.table_covered_table_cell)]
        public List<TableCellBase> table_cell_element { get; set; } = new List<TableCellBase>();
    }
}
