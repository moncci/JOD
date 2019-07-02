using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class TableTableColumn
    {
        [XmlAttribute(WriterKeyword.table_style_name)]
        public string table_style_name { get; set; }
    }
}
