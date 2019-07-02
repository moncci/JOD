using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JOD.Writer.Models.rdf
{
    public class RdfKeyword : WriterKeyword
    {
        [XmlKeyword("rdf:RDF")]
        public const string rdf = "rdf" + General.CONLON + "RDF";
        [XmlKeyword("xmlns:rdf")]
        public const string xmlnsrdf = "xmlns" + General.CONLON + "rdf";
        [XmlKeyword("rdf:Description")]
        public const string rdfDescription = "rdf" + General.CONLON + "Description";
        [XmlKeyword("rdf:about")]
        public const string rdfabout = "rdf" + General.CONLON + "about";
        [XmlKeyword("rdf:type")]
        public const string rdftype = "rdf" + General.CONLON + "type";
        [XmlKeyword("rdf:resource")]
        public const string rdfresource = "rdf" + General.CONLON + "resource";
        [XmlKeyword("ns0:hasPart")]
        public const string ns0hasPart = "ns0" + General.CONLON + "hasPart";
        [XmlKeyword("xmlns:ns0")]
        public const string xmlnsns0 = "xmlns" + General.CONLON + "ns0";
    }
}
