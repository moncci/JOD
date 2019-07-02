using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class ViewSetting 
    {
        [XmlElement(SettingKeyword.config_config_item)]
        public List<ConfigItem> config_item_list { get; set; } = new List<ConfigItem>()
        {
            new ConfigItem(){ config_name="ViewAreaTop", config_type="long", value="0"},
            new ConfigItem(){ config_name="ViewAreaLeft", config_type="long", value="0"},
            new ConfigItem(){ config_name="ViewAreaWidth", config_type="long", value="24978"},
            new ConfigItem(){ config_name="ViewAreaHeight", config_type="long", value="8918"},
            new ConfigItem(){ config_name="ShowRedlineChanges", config_type="boolean", value="true"},
            new ConfigItem(){ config_name="InBrowseMode", config_type="boolean", value="false"}
        };

        [XmlElement(SettingKeyword.config_config_item_map_indexed)]
        public ConfigItemMapIndexed config_config_item_map_indexed { get; set; } = new ConfigItemMapIndexed();


        public ViewSetting()
        {
            //config_name = "ooo:view-settings";
        }
    }
}
