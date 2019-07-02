using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class StyleTableRowProperties
    {
        [XmlAttribute(WriterKeyword.fo_keep_together)]
        public string fo_keep_together { get; set; }
    }
}
