using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal class User : IPerson
    {
        public User(int iD, string name, string passportData, int age, int salary, int debt)
        {
            ID = iD;
            Name = name;
            PassportData = passportData;
            Age = age;
            Salary = salary;
            Debt = debt;
        }

        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public string PassportData { get ; set ; }
        public int Age { get ; set ; }

        public int Salary { get; set; }

        public int Debt { get; set; }

        public User()
        {

        }
    }
}
