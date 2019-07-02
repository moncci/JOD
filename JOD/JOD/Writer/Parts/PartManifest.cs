using JOD.Utils;
using JOD.Writer.Models.manifest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartManifest
    {
        private List<FileEntry> _fileList;

        public PartManifest()
        {
            _fileList = new List<FileEntry>();
        }

        public void AddFileEntry(FileEntry file)
        {
            _fileList.Add(file);
        }



        public void CreatNewPart()
        {
            Manifest p = new Manifest();
            if(_fileList != null && _fileList.Count > 0)
            {
                foreach (var item in _fileList)
                {
                    p.AddFileEntry(item);
                }
            }
            string xml = p.Serialize();
            xml = xml.ToXmlConlon<ManifestKeyword>();
            string tempPath = General.tempPath;
            string dir = Path.Combine(tempPath, "META-INF");
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileFullName = Path.Combine(dir, "manifest.xml");
            FileHelper.WriteXmlFle(fileFullName, xml);
        }
    }
}
