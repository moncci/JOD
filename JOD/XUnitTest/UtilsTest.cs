using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using JOD.Utils;
using JOD.Writer.Models.manifest;
using JOD.Writer.Models.rdf;
using JOD.Writer.Parts;
using JOD;
using System.IO;
using JOD.Writer.Enum;
using JOD.Writer;
using JjPolice.Base.CommonCp.ZXingNet;
using System.Drawing;

namespace XUnitTest
{
    public class UtilsTest
    {
        [Fact]
        public void Writer创建默认()
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

        }
        [Fact]
        public void XmlConverter创建Configurations2()
        {
            General.ClearTempPath();
            PartConfigurations2 p = new PartConfigurations2();
            p.CreatNewPart();
        }
        [Fact]
        public void XmlConverter创建Manifest的xml()
        {
            General.ClearTempPath();
            PartManifest p = new PartManifest();
            p.CreatNewPart();
        }

        [Fact]
        public void XmlConverter创建Thumbnail()
        {
            General.ClearTempPath();
            PartThumbnail p = new PartThumbnail();
            p.CreatNewPart();
        }

        [Fact]
        public void XmlConverter创建RDF的xml()
        {
            General.ClearTempPath();
            PartRdf p = new PartRdf();
            p.CreatNewPart();            
        }
        [Fact]
        public void XmlConverter创建Mimetype()
        {
            General.ClearTempPath();
            PartMimetype p = new PartMimetype();
            p.CreatNewPart();
        }

        [Fact]
        public void Jod_CreateNewWriter()
        {
            string dir = @"C:\Users\19095\Desktop";
            string filename = Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss")+".odt");
            Jod.CreateNewWriter(filename);
        }

        [Fact]
        public void Jod_CreateWriterDocument()
        {
            string dir = @"C:\Users\19095\Desktop";
            string filename = Path.Combine(dir, DateTime.Now.ToString("yyyyMMddHHmmss") + ".odt");
            WriterDocument writer = new WriterDocument();
            writer.SetPaperSize(10, 5.5, 0, 0, 0.1, 0.1);
            Paragraph p = new Paragraph();
            p.Text = "温江区公安局刑事技术室";
            p.TextAlign = TextAlignEnum.center;
            p.FontWeight = FontWeightEnum.bold;
            writer.AddParagraph(p);

            Table t1 = new Table();
            t1.AddColumn(2487);
            t1.AddColumn(4710);
            t1.AddColumn(2803);
            FtStyle fstyle_title = new FtStyle();
            fstyle_title.FontWeight = FontWeightEnum.bold;
            fstyle_title.TextAlign = TextAlignEnum.center;
            FtStyle fstyle_content = new FtStyle();
            t1.AddCell("物证名称", fstyle_title);
            t1.AddCell("烟头", fstyle_content, 2);
            t1.AddCell("物证编号", fstyle_title);
            t1.AddCell("W20190003", fstyle_content, 2);
            t1.AddCell("提取人", fstyle_title);
            t1.AddCell("张三、李四", fstyle_content);
            string qrcord = "wz51012300002019060078";
            Bitmap bitmap = BarcodeHelper.CreateQrCode(qrcord, 200, 200);
            Bitmap newBitmap = CutImage.CutImageWhitePart(bitmap);
            t1.AddCellImage(newBitmap, 2.5, 2.5, fstyle_content, 1, 3);
            t1.AddCell("提取时间", fstyle_title);
            t1.AddCell("2019年6月1日", fstyle_content);
            t1.AddCell("数量", fstyle_title);
            t1.AddCell("1枚", fstyle_content);
            writer.AddTable(t1);

            writer.SaveFile(filename);
        }

        

        [Fact]
        public void Jod_枚举测试()
        {
            //TextAlignEnum t = TextAlignEnum.end;
            //string ssss = t.EnumConvertToString();

            //string abc = "center2";
            //TextAlignEnum a;
            //bool b = abc.StringConvertToEnum<TextAlignEnum>(out a);

            string m = LetterHelper.GetLetter(676);
        }
    }
}
