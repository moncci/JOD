using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class ConfigItemMapEntry
    {
        [XmlElement(SettingKeyword.config_config_item)]
        public List<ConfigItem> config_item_list { get; set; } = new List<ConfigItem>()
        {
            new ConfigItem(){ config_name="ViewId", config_type="string", value="view2"},
            new ConfigItem(){ config_name="ViewLeft", config_type="long", value="3694"},
            new ConfigItem(){ config_name="ViewTop", config_type="long", value="2501"},
            new ConfigItem(){ config_name="VisibleLeft", config_type="long", value="0"},
            new ConfigItem(){ config_name="VisibleTop", config_type="long", value="0"},
            new ConfigItem(){ config_name="VisibleRight", config_type="long", value="24977"},
            new ConfigItem(){ config_name="VisibleBottom", config_type="long", value="8916"},
            new ConfigItem(){ config_name="ZoomType", config_type="short", value="0"},
            new ConfigItem(){ config_name="ViewLayoutColumns", config_type="short", value="1"},
            new ConfigItem(){ config_name="ViewLayoutBookMode", config_type="boolean", value="false"},
            new ConfigItem(){ config_name="ZoomFactor", config_type="short", value="100"},
            new ConfigItem(){ config_name="IsSelectedFrame", config_type="boolean", value="false"},
            new ConfigItem(){ config_name="AnchoredTextOverflowLegacy", config_type="boolean", value="false"}
        };
    }
}
