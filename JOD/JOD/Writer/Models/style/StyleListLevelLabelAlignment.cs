using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class StyleListLevelLabelAlignment
    {
        [XmlAttribute(StyleKeyword.text_label_followed_by)]
        public string text_label_followed_by { get; set; }
    }
}
