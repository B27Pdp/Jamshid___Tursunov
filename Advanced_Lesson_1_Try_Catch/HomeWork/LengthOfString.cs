using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_1_Try_Catch.HomeWork
{
    internal class LengthOfString
    {

        public static void StartUp()
        {

            try
            {
                string? str = Console.ReadLine();
                if (str.Length != 0)
                {
                    Console.WriteLine(str.Length);

                }
                else throw new ArgumentException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);


            }


        }

    }
    partial class ArgumentException :SystemException
    {

    public string Message { get; } = "Kiritilgan matn bo'sh bo'lmasligi kerak. ";
    }


}
