using JOD.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartMimetype
    {
        public void CreatNewPart()
        {
            //string mimetype = "application/vnd.oasis.opendocument.text";

            //string tempPath = General.tempPath;
            //string fileFullName = Path.Combine(tempPath, "mimetype");
            //FileHelper.WriteXmlFle(fileFullName, mimetype);


            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "mimetype");

            byte[] png = ResourceHelper.GetResource("mimetype");
            if (png != null)
            {
                using (FileStream pngFile = new FileStream(fileFullName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    pngFile.Write(png, 0, png.Length);
                }
            }
        }
    }
}
