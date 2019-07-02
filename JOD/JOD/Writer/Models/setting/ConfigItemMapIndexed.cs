using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class ConfigItemMapIndexed
    {
        [XmlAttribute(SettingKeyword.config_name)]
        public string config_name { get; set; } = "Views";

        [XmlElement(SettingKeyword.config_config_item_map_entry)]
        public ConfigItemMapEntry config_config_item_map_entry { get; set; } = new ConfigItemMapEntry();
    }
}
