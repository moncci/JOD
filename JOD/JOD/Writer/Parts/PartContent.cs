using JOD.Utils;
using JOD.Writer.Models.content;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartContent
    {
        public void CreatNewPart()
        {
            OfficeDocumentContent p = new OfficeDocumentContent();            

            string xml = p.Serialize();
            xml = xml.ToXmlConlon<ContentKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "content.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }

        public void CreatNewPart(List<Element> elemList, double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight, PartManifest pmanifest)
        {
            OfficeDocumentContent p = new OfficeDocumentContent();
            p.SetElements(elemList, width, height, marginTop, marginBottom, marginLeft, marginRight, pmanifest);

            string xml = p.Serialize();
            xml = xml.ToXmlConlon<ContentKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "content.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
