using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.meta
{
    [XmlType(MetaKeyword.office_document_meta)]
    public class Meta
    {
        [XmlAttribute(MetaKeyword.xmlns_office)]
        public string xmlns_office { get; set; } = "urn:oasis:names:tc:opendocument:xmlns:office:1.0";

        [XmlAttribute(MetaKeyword.xmlns_xlink)]
        public string xmlns_xlink { get; set; } = "http://www.w3.org/1999/xlink";

        [XmlAttribute(MetaKeyword.xmlns_dc)]
        public string xmlns_dc { get; set; } = "http://purl.org/dc/elements/1.1/";

        [XmlAttribute(MetaKeyword.xmlns_meta)]
        public string xmlns_meta { get; set; } = "urn:oasis:names:tc:opendocument:xmlns:meta:1.0";

        [XmlAttribute(MetaKeyword.xmlns_ooo)]
        public string xmlns_ooo { get; set; } = "http://openoffice.org/2004/office";

        [XmlAttribute(MetaKeyword.xmlns_grddl)]
        public string xmlns_grddl { get; set; } = "http://www.w3.org/2003/g/data-view#";

        [XmlAttribute(MetaKeyword.office_version)]
        public string office_version { get; set; } = "1.2";

        [XmlElement(MetaKeyword.office_meta)]
        public OfficeMeta officeMeta { get; set; } = new OfficeMeta();
    }
}
