using JOD.Attributes;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace JOD.Writer.Models.manifest
{
    public class ManifestKeyword : WriterKeyword
    {
        [XmlKeyword("manifest:manifest")]
        public const string manifest_manifest = "manifest" + General.CONLON + "manifest";
        [XmlKeyword("xmlns:manifest")]
        public const string xmlns_manifest = "xmlns" + General.CONLON + "manifest";
        [XmlKeyword("manifest:version")]
        public const string manifest_version = "manifest" + General.CONLON + "version";
        [XmlKeyword("manifest:file-entry")]
        public const string manifest_file_entry = "manifest" + General.CONLON + "file-entry";
        [XmlKeyword("manifest:full-path")]
        public const string manifest_full_path = "manifest" + General.CONLON + "full-path";
        [XmlKeyword("manifest:media-type")]
        public const string manifest_media_type = "manifest" + General.CONLON + "media-type";
    }
}
