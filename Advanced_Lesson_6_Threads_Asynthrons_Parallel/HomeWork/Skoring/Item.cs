using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public byte Guarantee { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Guarantee);
            Console.WriteLine(this.Price);
        }
    }
}
