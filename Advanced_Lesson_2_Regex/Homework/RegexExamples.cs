using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework
{
    internal class RegexExamples
    {
       public static void Start()
        {
            //Console.WriteLine("Jamshid\b Sardor");
            //Console.WriteLine("Jamshid\a Sardor");
            //Console.WriteLine("Jamshid\tSardor");
            //Console.WriteLine("Jamshid  \f  Sardor");
            //Console.WriteLine("Jamshid\vSardor");
            //Console.WriteLine("Jamshid\fSardor");

        

                //string str = "chatting";
                //Console.WriteLine(Regex.IsMatch(str,"a") );
              //  Console.WriteLine("Filling form: ");
            //Console.Write("Input name: ");
            //string name = Console.ReadLine();
            ////if(Regex.IsMatch(name,@"^[A-Z][a-z]+$"))
            //    Console.WriteLine("we have got your name successfully. ");
            //else Console.WriteLine("Invalid name. ");
            //Console.Write("Input Your password ID and series=> ");
            //string? password = Console.ReadLine();
            //Console.WriteLine(Regex.IsMatch(password, @"^[A-Z]{2}[0-9]{7}$"));
            /*
            (+998) 93 123 12 12
            931231212
            93 123 12 12
            (+998) 931231212
            +998931231212
            998931231212
            +998 93 123 12 12
            +998 93 1231212

            */


            //  string PhoneNumber = "(+998) 93 123 12 12";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //   PhoneNumber = "931231212";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //  PhoneNumber = "93 123 12 12";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //   PhoneNumber = "(+998) 931231212";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //   PhoneNumber = "+998931231212";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //   PhoneNumber = "998931231212";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //PhoneNumber = "+998 93 123 12 12";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));
            //PhoneNumber = "+998 93 1231212";
            //  Console.WriteLine(Regex.IsMatch(PhoneNumber,@"((\(?\+998\))\s?)?(33|(9(1|3|4|5|7|9|0)))\s?\d{3}\s?\d{2}\s?\d{2}"));

            string satr = "  12dsfsf2342 ";
            MatchCollection matchh = Regex.Matches(satr, @"\d");
            foreach (Match match in matchh)
            {
                Console.WriteLine(match);
            }

            



        }



    }
}
