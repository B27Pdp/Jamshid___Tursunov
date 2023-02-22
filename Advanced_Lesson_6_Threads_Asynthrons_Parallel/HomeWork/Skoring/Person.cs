using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal class Person : IPerson
    {
        public Person(int iD, string name, string passportData, int age, bool isMarried)
        {
            ID = iD;
            Name = name;
            PassportData = passportData;
            Age = age;
            IsMarried = isMarried;
        }

        public int ID { get ; set; }
        public string Name { get ; set; }
        public string PassportData { get ; set ; }
        public int Age { get ; set ; }
        public bool IsMarried { get; set; }
        public Person()
        {

        }
    }
}
