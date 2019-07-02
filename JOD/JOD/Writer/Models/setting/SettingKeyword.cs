using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JOD.Writer.Models.setting
{
    public class SettingKeyword : WriterKeyword
    {
        [XmlKeyword("office:document-settings")]
        public const string office_document_settings = "office" + General.CONLON + "document-settings";

        [XmlKeyword("xmlns:office")]
        public const string xmlns_office = "xmlns" + General.CONLON + "office";

        [XmlKeyword("xmlns:xlink")]
        public const string xmlns_xlink = "xmlns" + General.CONLON + "xlink";

        [XmlKeyword("xmlns:config")]
        public const string xmlns_config = "xmlns" + General.CONLON + "config";

        [XmlKeyword("xmlns:ooo")]
        public const string xmlns_ooo = "xmlns" + General.CONLON + "ooo";

        [XmlKeyword("office:version")]
        public const string office_version = "office" + General.CONLON + "version";




        [XmlKeyword("office:settings")]
        public const string office_settings = "office" + General.CONLON + "settings";

        [XmlKeyword("config:config-item-set")]
        public const string config_config_item_set = "config" + General.CONLON + "config-item-set";

        [XmlKeyword("config:name")]
        public const string config_name = "config" + General.CONLON + "name";

        [XmlKeyword("config:config-item")]
        public const string config_config_item = "config" + General.CONLON + "config-item";

        [XmlKeyword("config:type")]
        public const string config_type = "config" + General.CONLON + "type";


        [XmlKeyword("config:config-item-map-indexed")]
        public const string config_config_item_map_indexed = "config" + General.CONLON + "config-item-map-indexed";

        [XmlKeyword("config:config-item-map-entry")]
        public const string config_config_item_map_entry = "config" + General.CONLON + "config-item-map-entry";
    }
}
