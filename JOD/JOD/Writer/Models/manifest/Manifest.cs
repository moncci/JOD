using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.manifest
{
    [XmlType(ManifestKeyword.manifest_manifest)]
    public class Manifest
    {
        [XmlAttribute(ManifestKeyword.xmlns_manifest)]
        public string Xmlns { get; set; } = "urn:oasis:names:tc:opendocument:xmlns:manifest:1.0";

        [XmlAttribute(ManifestKeyword.manifest_version)]
        public double version { get; set; } = Constant.office_version;

        [XmlAttribute(ManifestKeyword.xmlns_loext)]
        public string xmlns_loext { get; set; } = Constant.xmlns_loext;

        [XmlElement(ManifestKeyword.manifest_file_entry)]
        public List<FileEntry> listFileEntry { get; set; } = new List<FileEntry>()
        {
            new FileEntry(){FullPath = "/", MediaType = "application/vnd.oasis.opendocument.text", Version = "1.2"},
            new FileEntry() { FullPath = "Configurations2/", MediaType = "application/vnd.sun.xml.ui.configuration" },
            new FileEntry() { FullPath = "styles.xml", MediaType = "text/xml" },
            new FileEntry() { FullPath = "manifest.rdf", MediaType = "application/rdf+xml" },
            new FileEntry() { FullPath = "meta.xml", MediaType = "text/xml" },
            new FileEntry() { FullPath = "settings.xml", MediaType = "text/xml" },
            new FileEntry() { FullPath = "Thumbnails/thumbnail.png", MediaType = "image/png" },
            new FileEntry() { FullPath = "content.xml", MediaType = "text/xml" }
        };

        public void AddFileEntry(FileEntry file)
        {
            listFileEntry.Add(file);
        }
    }
}
