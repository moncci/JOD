using JOD.Utils;
using JOD.Writer.Models.rdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartRdf
    {
        public void CreatNewPart()
        {
            RDF p = new RDF();
            string xml = p.Serialize();
            xml = xml.ToXmlConlon<RdfKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "manifest.rdf");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
