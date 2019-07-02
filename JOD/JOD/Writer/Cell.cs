using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JOD.Writer
{
    public class Cell
    {
        public string Text { get; set; }

        public int ColumnsSpanned { get; set; }

        public int RowsSpanned { get; set; }
        public double padding { get; set; }
        public FtStyle fStyle { get; set; }
        public bool isImage { get; set; }
        public string imgPath { get; set; }

        public Bitmap bitmap { get; set; }
        public double imgWidth { get; set; }
        public double imgHeight { get; set; }
    }
}
