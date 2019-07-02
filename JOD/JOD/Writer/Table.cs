using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JOD.Writer
{
    /// <summary>
    /// 表格
    /// </summary>
    public class Table : Element
    {
        /// <summary>
        /// 表格宽度
        /// </summary>
        internal double Width { get; set; }

        internal List<int> _columnList = new List<int>();

        private List<int> _rowList = new List<int>();

        internal List<Cell> _cellList = new List<Cell>();
        /// <summary>
        /// 添加列
        /// </summary>
        /// <param name="proportion">比例</param>
        public void AddColumn(int proportion)
        {
            _columnList.Add(proportion);
        }

        public void AddCell(string content, FtStyle fstyle = null, int columnsSpanned = 1, int rowsSpanned = 1, double padding = 0.097)
        {
            Cell c = new Cell();
            c.ColumnsSpanned = columnsSpanned;
            c.RowsSpanned = rowsSpanned;
            c.Text = content;
            c.padding = padding;
            c.fStyle = fstyle;
            c.isImage = false;
            _cellList.Add(c);
        }

        public void AddCellImage(string imagePath,double width,double height, FtStyle fstyle = null, int columnsSpanned = 1, int rowsSpanned = 1, double padding = 0.097)
        {
            Cell c = new Cell();
            c.ColumnsSpanned = columnsSpanned;
            c.RowsSpanned = rowsSpanned;
            c.padding = padding;
            c.fStyle = fstyle;
            c.isImage = true;
            c.imgPath = imagePath;
            c.imgWidth = width;
            c.imgHeight = height;
            _cellList.Add(c);
        }

        public void AddCellImage(Bitmap bitmap, double width, double height, FtStyle fstyle = null, int columnsSpanned = 1, int rowsSpanned = 1, double padding = 0.097)
        {
            Cell c = new Cell();
            c.ColumnsSpanned = columnsSpanned;
            c.RowsSpanned = rowsSpanned;
            c.padding = padding;
            c.fStyle = fstyle;
            c.isImage = true;
            c.bitmap = bitmap;
            c.imgWidth = width;
            c.imgHeight = height;
            _cellList.Add(c);
        }
    }
}
