using JOD.Utils;
using JOD.Writer.Models.style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartStyle
    {
        public void CreatNewPart()
        {
            OfficeDocumentStyles p = new OfficeDocumentStyles();

            string xml = p.Serialize();
            xml = xml.ToXmlConlon<StyleKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "styles.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }

        public void CreatNewPart(double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight)
        {
            OfficeDocumentStyles p = new OfficeDocumentStyles();
            p.SetPaperSize(width, height, marginTop, marginBottom, marginLeft, marginRight);
            string xml = p.Serialize();
            xml = xml.ToXmlConlon<StyleKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "styles.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
