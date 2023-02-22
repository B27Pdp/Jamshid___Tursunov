using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.LessonWork
{
    internal class Asychron
    {
        public static async void Start()
        {
            Console.WriteLine("Main function started. ");
            //  VoidFunc();
           // Task<string> mess=GenericTaskFunc();
            
            Difference();

            Console.WriteLine("Main function ended. ");
          //  Console.WriteLine(mess.Result);
            Console.ReadKey();

        }

        async static Task<string> GenericTaskFunc()
        {
            Console.WriteLine("task generic has started. ");
            await Task.Delay(2000);
            Console.WriteLine("\n Task generic function finished");
            return "return message. ";
        }

        async static void VoidFunc()
        {
            Console.WriteLine("Void functioin started. ");
            await Task.Delay(2000);
            Console.WriteLine("\n Void function finished");
            throw new Exception("error in void function. ");

        }
        async static Task TaskFunc()
        {
            Console.WriteLine("Task functioin started. ");
            await Task.Delay(2000);
            Console.WriteLine("\n Task function finished");
            throw new Exception("error in task function. ");
        }

         async  static Task Difference()
        {
            try
            {
                VoidFunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                TaskFunc();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }


    }

}
