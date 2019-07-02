using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.rdf
{
    public class RdfType
    {
        [XmlAttribute(RdfKeyword.rdfresource)]
        public string rdfresource { get; set; }
    }
}
