using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.style
{
    public class OfficeMasterStyles
    {
        [XmlElement(StyleKeyword.style_master_page)]
        public StyleMasterPage style_master_page { get; set; }

        public OfficeMasterStyles()
        {
            style_master_page = new StyleMasterPage()
            {
                style_name = "Standard",
                style_page_layout_name = "Mpm1"
            };
        }
    }
}
