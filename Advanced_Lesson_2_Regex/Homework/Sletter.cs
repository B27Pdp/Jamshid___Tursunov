using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework
{
    internal class Sletter
    {
        public static void Start()
        {
            List<string> names = new() 
            {
                "Abror", "Jamshid", "Sard5or",
            "SarVar" , "Davron"
            
            };
            foreach (var item in names)
            {
                if (Regex.IsMatch(item, "(^S[a-z]+$)")) 
                    Console.WriteLine(item);
            }



        }



    }
}
