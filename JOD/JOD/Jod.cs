using JOD.Writer.Parts;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace JOD
{
    public class Jod
    {
        public static void CreateNewWriter(string filename)
        {
            General.ClearTempPath();
            PartConfigurations2 p1 = new PartConfigurations2();
            p1.CreatNewPart();
            PartManifest p2 = new PartManifest();
            p2.CreatNewPart();
            PartThumbnail p3 = new PartThumbnail();
            p3.CreatNewPart();
            PartRdf p4 = new PartRdf();
            p4.CreatNewPart();
            PartMimetype p5 = new PartMimetype();
            p5.CreatNewPart();
            PartMeta p6 = new PartMeta();
            p6.CreatNewPart();
            PartSetting p7 = new PartSetting();
            p7.CreatNewPart();
            PartStyle p8 = new PartStyle();
            p8.CreatNewPart();
            PartContent p9 = new PartContent();
            p9.CreatNewPart();

            string dir = General.tempPath;
            ZipFile.CreateFromDirectory(dir, filename, CompressionLevel.Fastest, false);
        }
    }
}
