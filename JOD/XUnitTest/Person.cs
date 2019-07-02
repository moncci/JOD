using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace XUnitTest
{
    [XmlType("Person")]
    public class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        [Required]
        public int Age { get; set; }
    }
}
