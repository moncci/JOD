using JOD.Writer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer
{
    public class Paragraph : Element
    {
        /// <summary>
        /// 段落文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 段落文本对齐方式
        /// </summary>
        public TextAlignEnum TextAlign { get; set; } = TextAlignEnum.start;
        /// <summary>
        /// 文本颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 删除线样式
        /// </summary>
        public TextLineThroughStyle TextLineThroughStyle { get; set; }
        /// <summary>
        /// 删除线类型
        /// </summary>
        public TextLineThroughType TextLineThroughType { get; set; }
        /// <summary>
        /// 字号(单位pt)
        /// </summary>
        public FontSizeEnum FontSize { get; set; } = FontSizeEnum.四号;
        /// <summary>
        /// 字体样式(斜体)
        /// </summary>
        public FtStyleEnum FtStyle { get; set; }
        /// <summary>
        /// 下划线样式
        /// </summary>
        public TextUnderlineStyle TextUnderlineStyle { get; set; }
        /// <summary>
        /// 字体加粗
        /// </summary>
        public FontWeightEnum FontWeight { get; set; }
        /// <summary>
        /// 文本背景颜色
        /// </summary>
        public string BackgroudColor { get; set; }
        /// <summary>
        /// 字体名称
        /// </summary>
        public string FontName { get; set; } = "宋体";
    }
}
