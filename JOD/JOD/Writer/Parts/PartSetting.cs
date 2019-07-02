using JOD.Utils;
using JOD.Writer.Models.setting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartSetting
    {
        public void CreatNewPart()
        {
            Settings p = new Settings();
            string xml = p.Serialize();
            xml = xml.ToXmlConlon<SettingKeyword>();
            string tempPath = General.tempPath;
            string fileFullName = Path.Combine(tempPath, "settings.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
