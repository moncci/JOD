using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartPicture
    {
        public static string CreatPictule(string imgPath)
        {
            string tempPath = General.tempPath;
            string dir = Path.Combine(tempPath, "Pictures");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileName = Path.GetFileName(imgPath);
            string ext = Path.GetExtension(imgPath);
            string newFileName = Guid.NewGuid().ToString("N") + ext;
            string newPath = Path.Combine(dir, newFileName);
            //string fileFullName = Path.Combine(dir, "thumbnail.png");

            //byte[] png = ResourceHelper.GetResource("thumbnail.png");
            //if (png != null)
            //{
            //    using (FileStream pngFile = new FileStream(fileFullName, FileMode.Create, FileAccess.Write, FileShare.None))
            //    {
            //        pngFile.Write(png, 0, png.Length);
            //    }
            //}

            FileInfo file = new FileInfo(imgPath);
            if (file.Exists)
            {
                // true is overwrite
                file.CopyTo(newPath, true);
            }
            string newName = "Pictures/" + newFileName;
            return newName;
        }

        public static string CreatPictule(Bitmap bitmap)
        {
            string tempPath = General.tempPath;
            string dir = Path.Combine(tempPath, "Pictures");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string ext = ".jpg";
            string newFileName = Guid.NewGuid().ToString("N") + ext;
            string newPath = Path.Combine(dir, newFileName);

            bitmap.Save(newPath, ImageFormat.Jpeg);

            string newName = "Pictures/" + newFileName;
            return newName;
        }
    }
}
