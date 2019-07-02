using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.setting
{
    public class ConfigItemSet
    {
        [XmlAttribute(SettingKeyword.config_name)]
        public string config_name { get; set; }

        [XmlElement(SettingKeyword.config_config_item)]
        public List<ConfigItem> config_item_list { get; set; }

        [XmlElement(SettingKeyword.config_config_item_map_indexed)]
        public ConfigItemMapIndexed config_config_item_map_indexed { get; set; }

        public ConfigItemSet Ini(SettingTypeEnum settingType)
        {
            switch (settingType)
            {
                case SettingTypeEnum.View:
                    IniViewSettings();
                    break;
                case SettingTypeEnum.Configuration:
                    IniConfigurationSettings();
                    break;
                default:
                    config_name = "none";
                    break;
            }
            return this;
        }

        private void IniViewSettings()
        {
            config_name = "ooo:view-settings";
            config_item_list = new List<ConfigItem>()
            {
                new ConfigItem(){ config_name="ViewAreaTop", config_type="long", value="0"},
                new ConfigItem(){ config_name="ViewAreaLeft", config_type="long", value="0"},
                new ConfigItem(){ config_name="ViewAreaWidth", config_type="long", value="24978"},
                new ConfigItem(){ config_name="ViewAreaHeight", config_type="long", value="8918"},
                new ConfigItem(){ config_name="ShowRedlineChanges", config_type="boolean", value="true"},
                new ConfigItem(){ config_name="InBrowseMode", config_type="boolean", value="false"}
            };
            config_config_item_map_indexed = new ConfigItemMapIndexed();

        }

        private void IniConfigurationSettings()
        {
            config_name = "ooo:configuration-settings";
            config_item_list = new List<ConfigItem>()
        {
            new ConfigItem(){ config_name="ProtectForm", config_type="boolean", value="false"},
            new ConfigItem(){ config_name="PrinterName", config_type="string"},
            new ConfigItem(){ config_name="EmbeddedDatabaseName", config_type="string"},
            new ConfigItem() { config_name = "CurrentDatabaseDataSource", config_type = "string"},
            new ConfigItem() { config_name = "LinkUpdateMode", config_type = "short", value="1"},
            new ConfigItem() { config_name = "AddParaTableSpacingAtStart", config_type = "boolean", value="true"},
            new ConfigItem() { config_name = "FloattableNomargins", config_type = "boolean", value="false"},
            new ConfigItem() { config_name = "UnbreakableNumberings", config_type = "boolean", value="false"},
            new ConfigItem() { config_name = "FieldAutoUpdate", config_type = "boolean", value="true"},
            new ConfigItem() { config_name = "AddVerticalFrameOffsets", config_type = "boolean", value="false"},
            new ConfigItem() { config_name = "BackgroundParaOverDrawings", config_type = "boolean", value="false"},
            new ConfigItem() { config_name = "AddParaTableSpacing", config_type = "boolean", value="true"},
            new ConfigItem() { config_name = "ChartAutoUpdate", config_type = "boolean", value="true"},
            new ConfigItem() { config_name = "CurrentDatabaseCommand", config_type = "string"},
            new ConfigItem() { config_name = "AlignTabStopPosition", config_type = "boolean", value="true"},
            new ConfigItem() { config_name = "PrinterSetup", config_type = "base64Binary"},
            new ConfigItem() { config_name = "IsKernAsianPunctuation", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "CharacterCompressionType", config_type = "short",value="0"},
            new ConfigItem() { config_name = "ApplyUserData", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "SaveGlobalDocumentLinks", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "SurroundTextWrapSmall", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "SmallCapsPercentage66", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "CurrentDatabaseCommandType", config_type = "int",value="0"},
            new ConfigItem() { config_name = "SaveVersionOnClose", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "UpdateFromTemplate", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintSingleJobs", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrinterIndependentLayout", config_type = "string",value="high-resolution"},
            new ConfigItem() { config_name = "EmbedSystemFonts", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "DoNotCaptureDrawObjsOnPage", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "UseFormerObjectPositioning", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "IsLabelDocument", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "AddFrameOffsets", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "AddExternalLeading", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "UseOldNumbering", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "OutlineLevelYieldsNumbering", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "DoNotResetParaAttrsForNumFont", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "IgnoreFirstLineIndentInNumbering", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "AllowPrintJobCancel", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "UseFormerLineSpacing", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "AddParaSpacingToTableCells", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "UseFormerTextWrapping", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "RedlineProtectionKey", config_type = "base64Binary"},
            new ConfigItem() { config_name = "ConsiderTextWrapOnObjPos", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "DoNotJustifyLinesWithManualBreak", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "EmbedFonts", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "TableRowKeep", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "TabsRelativeToIndent", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "IgnoreTabsAndBlanksForLineCalculation", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "RsidRoot", config_type = "int",value="3071"},
            new ConfigItem() { config_name = "LoadReadonly", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "ClipAsCharacterAnchoredWriterFlyFrames", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "UnxForceZeroExtLeading", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "UseOldPrinterMetrics", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "TabAtLeftIndentForParagraphsInList", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "Rsid", config_type = "int",value="3071"},
            new ConfigItem() { config_name = "MsWordCompTrailingBlanks", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "MathBaselineAlignment", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "InvertBorderSpacing", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "CollapseEmptyCellPara", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "TabOverflow", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "StylesNoDefault", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "ClippedPictures", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "TabOverMargin", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "TreatSingleColumnBreakAsPageBreak", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "ApplyParagraphMarkFormatToNumbering", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PropLineSpacingShrinksFirstLine", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "SubtractFlysAnchoredAtFlys", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintAnnotationMode", config_type = "short",value="0"},
            new ConfigItem() { config_name = "PrintGraphics", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintBlackFonts", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintProspect", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintLeftPages", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintControls", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintPageBackground", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintTextPlaceholder", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintDrawings", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintHiddenText", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintTables", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintProspectRTL", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintReversed", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintRightPages", config_type = "boolean",value="true"},
            new ConfigItem() { config_name = "PrintFaxName", config_type = "string"},
            new ConfigItem() { config_name = "PrintPaperFromSetup", config_type = "boolean",value="false"},
            new ConfigItem() { config_name = "PrintEmptyPages", config_type = "boolean",value="false"}
        };
        }
    }
}
