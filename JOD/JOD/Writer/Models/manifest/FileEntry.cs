using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.manifest
{
    public class FileEntry
    {
        [XmlAttribute(ManifestKeyword.manifest_full_path)]
        public string FullPath { get; set; }
        [XmlAttribute(ManifestKeyword.manifest_media_type)]
        public string MediaType { get; set; }
        [XmlAttribute(ManifestKeyword.manifest_version)]
        public string Version { get; set; }
    }
}
