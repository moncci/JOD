using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.rdf
{
    [XmlType(RdfKeyword.rdf)]
    public class RDF
    {
        [XmlAttribute(RdfKeyword.xmlnsrdf)]
        public string Xmlnsrdf { get; set; } = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";
        [XmlElement(RdfKeyword.rdfDescription)]
        public List<RdfDescription> listDescription { get; set; } = new List<RdfDescription>()
        {
            new RdfDescription(){ rdfabout="styles.xml", rdftype=new RdfType(){  rdfresource="http://docs.oasis-open.org/ns/office/1.2/meta/odf#StylesFile"} },
            new RdfDescription(){ rdfabout="", ns0hasPart=new Ns0HasPart(){  Xmlnsns0="http://docs.oasis-open.org/ns/office/1.2/meta/pkg#", rdfresource="styles.xml"} },
            new RdfDescription(){ rdfabout="content.xml", rdftype=new RdfType(){  rdfresource="http://docs.oasis-open.org/ns/office/1.2/meta/odf#ContentFile"} },
            new RdfDescription(){ rdfabout="", ns0hasPart=new Ns0HasPart(){  Xmlnsns0="http://docs.oasis-open.org/ns/office/1.2/meta/pkg#", rdfresource="content.xml"} },
            new RdfDescription(){ rdfabout="", rdftype=new RdfType(){  rdfresource="http://docs.oasis-open.org/ns/office/1.2/meta/pkg#Document"} }
        };
    }
}
