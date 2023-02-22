using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork
{
    internal class Sychronization
    {

        public static void UsingMutex()
        {
           // Mutex NewMut = new Mutex(false, "Mymut");
            Thread curr = Thread.CurrentThread;
            curr.Name = "Main thread. ";
            Thread secondThread = new Thread(loop);
            secondThread.Name = "Second thread. ";
            secondThread.Start();
          //  NewMut.WaitOne();
             void loop()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " => " + i);
                }

            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" => "+ i);
            }

        }
       
    }
}
