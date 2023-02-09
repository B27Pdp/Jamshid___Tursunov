using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework
{
    internal class RemoveDigit
    {
        public static void Start()
        {
            string? str = Console.ReadLine();

            MatchCollection matches = Regex.Matches(str, @"\d");
            foreach (var item in matches)
            {
                    Console.WriteLine(item);
            }


        }


    }
}
