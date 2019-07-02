using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class OfficeSetting
    {
        //[XmlElement(SettingKeyword.config_config_item_set)]
       // public ViewSetting view_settings { get; set; } = new ViewSetting();

        //[XmlElement(SettingKeyword.config_config_item_set)]
        //public ConfigurationSetting configuration_settings { get; set; } = new ConfigurationSetting();

        [XmlElement(SettingKeyword.config_config_item_set)]
        public List<ConfigItemSet> config_set_list { get; set; } = new List<ConfigItemSet>()
        {
            (new ConfigItemSet()).Ini(SettingTypeEnum.View),
            (new ConfigItemSet()).Ini(SettingTypeEnum.Configuration)
        };
    }
}
