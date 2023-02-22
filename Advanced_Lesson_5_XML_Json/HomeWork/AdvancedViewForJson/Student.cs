using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_5_XML_Json.HomeWork.AdvancedViewForJson
{
    internal class Student
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public University? university { get; set; }
        public Gender gender { get; set; }
        public List<string>? sciences { get; set; }
    }
}
