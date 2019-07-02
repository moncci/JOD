using JOD.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartThumbnail
    {
        public void CreatNewPart()
        {
            string tempPath = General.tempPath;
            string dir = Path.Combine(tempPath, "Thumbnails");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileFullName = Path.Combine(dir, "thumbnail.png");

            byte[] png = ResourceHelper.GetResource("thumbnail.png");
            if(png != null)
            {
                using (FileStream pngFile = new FileStream(fileFullName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    pngFile.Write(png, 0, png.Length);
                }
            }
        }
    }
}
