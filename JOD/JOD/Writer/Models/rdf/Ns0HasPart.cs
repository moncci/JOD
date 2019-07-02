using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.rdf
{
    public class Ns0HasPart
    {
        [XmlAttribute(RdfKeyword.xmlnsns0)]
        public string Xmlnsns0 { get; set; }
        [XmlAttribute(RdfKeyword.rdfresource)]
        public string rdfresource { get; set; }
    }
}
