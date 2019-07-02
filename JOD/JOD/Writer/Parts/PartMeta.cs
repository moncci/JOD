using JOD.Utils;
using JOD.Writer.Models.meta;
using JOD.Writer.Models.rdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartMeta
    {
        public void CreatNewPart()
        {
            Meta p = new Meta();
            string xml = p.Serialize();
            xml = xml.ToXmlConlon<MetaKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "meta.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
