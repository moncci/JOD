using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class ConfigItem
    {
        [XmlAttribute(SettingKeyword.config_name)]
        public string config_name { get; set; }

        [XmlAttribute(SettingKeyword.config_type)]
        public string config_type { get; set; }

        [XmlText]
        public string value { get; set; }
    }
}
