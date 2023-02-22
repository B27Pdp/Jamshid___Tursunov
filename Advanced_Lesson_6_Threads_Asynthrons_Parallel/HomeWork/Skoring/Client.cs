using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal class Client : IPerson
    {
        public Client(int iD, string name, string passportData, int age, ActivitionDuration activitionDuration, PaymentHistory paymentHistory)
        {
            ID = iD;
            Name = name;
            PassportData = passportData;
            Age = age;
            this.activitionDuration = activitionDuration;
            this.paymentHistory = paymentHistory;
        }

        public int ID { get ; set ; }
        public string Name { get ; set ; }
        public string PassportData { get ; set ; }
        public int Age { get ; set ; }

        public ActivitionDuration activitionDuration { get; set; }
        public PaymentHistory paymentHistory { get; set; }

        public Client()
        {

        }
        //public BalanceUtilization balanceStatus { get; set; }
    }
}
