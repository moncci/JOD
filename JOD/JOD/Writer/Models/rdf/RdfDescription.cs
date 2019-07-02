using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.rdf
{
    public class RdfDescription
    {
        [XmlAttribute(RdfKeyword.rdfabout)]
        public string rdfabout { get; set; } = "";
        [XmlElement(RdfKeyword.rdftype)]
        public RdfType rdftype { get; set; }
        [XmlElement(RdfKeyword.ns0hasPart)]
        public Ns0HasPart ns0hasPart { get; set; }
    }
}
