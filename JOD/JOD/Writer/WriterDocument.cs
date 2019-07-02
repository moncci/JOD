using JOD.Writer.Enum;
using JOD.Writer.Parts;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;

namespace JOD.Writer
{
    public class WriterDocument
    {
        private double _paperWidth;
        private double _paperHeight;
        private double _marginTop;
        private double _marginBottom;
        private double _marginLeft;
        private double _marginRight;

        /// <summary>
        /// 段落
        /// </summary>
        private List<Element> _elementList;

        public WriterDocument()
        {
            _elementList = new List<Element>();
        }

        public void SetPaperSize(PaperSizeEnum pagesize)
        {
            switch (pagesize)
            {
                case PaperSizeEnum.A6:
                    break;
                case PaperSizeEnum.A4:
                    _paperHeight = 29.70;
                    _paperWidth = 21.00;
                    _marginTop = 2;
                    _marginBottom = _marginTop;
                    _marginLeft = _marginTop;
                    _marginRight = _marginTop;
                    break;
                default:
                    break;
            }
        }

        public void SetPaperSize(double width, double height, double marginTop, double marginBottom, double marginLeft, double marginRight)
        {
            _paperHeight = height;
            _paperWidth = width;
            _marginTop = marginTop;
            _marginBottom = marginBottom;
            _marginLeft = marginLeft;
            _marginRight = marginRight;
        }

        /// <summary>
        /// 添加段落
        /// </summary>
        /// <param name="para"></param>
        public void AddParagraph(Paragraph para)
        {
            if(para != null)
            {
                _elementList.Add(para);
            }
        }

        public void AddTable(Table table)
        {
            if(table != null)
            {
                _elementList.Add(table);
            }
        }

        public void SaveFile(string filename)
        {
            General.ClearTempPath();
            PartManifest pManifest = new PartManifest();

            PartConfigurations2 p1 = new PartConfigurations2();
            p1.CreatNewPart();
            
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
            p8.CreatNewPart(_paperWidth, _paperHeight, _marginTop, _marginBottom, _marginLeft, _marginRight);

            PartContent p9 = new PartContent();
            p9.CreatNewPart(_elementList, _paperWidth, _paperHeight, _marginTop, _marginBottom, _marginLeft, _marginRight, pManifest);

            pManifest.CreatNewPart();

            string dir = General.tempPath;
            ZipFile.CreateFromDirectory(dir, filename, CompressionLevel.Fastest, false);
        }
    }
}
