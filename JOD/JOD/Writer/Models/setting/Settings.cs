using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    [XmlType(SettingKeyword.office_document_settings)]
    public class Settings
    {
        [XmlAttribute(SettingKeyword.xmlns_office)]
        public string xmlns_office { get; set; } = "urn:oasis:names:tc:opendocument:xmlns:office:1.0";

        [XmlAttribute(SettingKeyword.xmlns_xlink)]
        public string xmlns_xlink { get; set; } = "http://www.w3.org/1999/xlink";

        [XmlAttribute(SettingKeyword.xmlns_config)]
        public string xmlns_config { get; set; } = "urn:oasis:names:tc:opendocument:xmlns:config:1.0";

        [XmlAttribute(SettingKeyword.xmlns_ooo)]
        public string xmlns_ooo { get; set; } = "http://openoffice.org/2004/office";

        [XmlAttribute(SettingKeyword.office_version)]
        public string office_version { get; set; } = "1.2";

        [XmlElement(SettingKeyword.office_settings)]
        public OfficeSetting office_settings { get; set; } = new OfficeSetting();

    }
}
