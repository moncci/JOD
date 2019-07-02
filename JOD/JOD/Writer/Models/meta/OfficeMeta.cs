using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.meta
{
    public class OfficeMeta
    {
        [XmlElement(MetaKeyword.meta_creation_date)]
        public string meta_creation_date { get; set; } = "2017-10-20T23:40:51.940000000";

        [XmlElement(MetaKeyword.meta_document_statistic)]
        public MetaDocumentStatistic meta_document_statistic { get; set; } = new MetaDocumentStatistic();

        [XmlElement(MetaKeyword.meta_generator)]
        public string meta_generator { get; set; } = "LibreOfficeDev/6.0.0.0.alpha0$Windows_x86 LibreOffice_project/a1f93eee75450c3ab6bc623bfad4f850260b86d0";
    }
}
