using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal interface IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PassportData  { get; set; }

        public int Age { get; set; }

    }
}
