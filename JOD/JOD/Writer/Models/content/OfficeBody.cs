using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.content
{
    public class OfficeBody
    {
        [XmlElement(ContentKeyword.office_text)]
        public OfficeText office_text { get; set; }

        public OfficeBody()
        {
            office_text = new OfficeText();
        }
    }
}
