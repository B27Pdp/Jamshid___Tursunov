using System.Collections.Generic;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.LessonWork
{
    internal class Multithreading
    {
        public static void ThreadAtributes()
        {
            Thread ThisThread = Thread.CurrentThread;
            Console.WriteLine("ThisThread.Thread =>" + ThisThread.ThreadState);
            Console.WriteLine("ThisThread.Name => " + ThisThread.Name);
            Console.WriteLine("ThisThread.IsAliv => " + ThisThread.IsAlive);
            Console.WriteLine("ThisThread.Current => " + ThisThread.CurrentCulture);
            Console.WriteLine("ThisThread.Priority => " + ThisThread.Priority);
            ThisThread.Interrupt();


        }
        public static void CreateThread()
        {
            Thread OriginalThread = Thread.CurrentThread;
            OriginalThread.Name = "Original thread";
            //Thread SecondThread = new Thread(Print);
            //SecondThread.Name = "Second thread";
            //SecondThread.Start();  
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(Thread.CurrentThread.Name+" => "+(i+10));
            //}
            for (int i = 1; i <= 5; i++)
            {
                Thread newthread = new Thread(Print);
                newthread.Name = $"{i} th thread";
                newthread.Start();
            }
        }

        public static void SynchronThreads()
        {
            Thread Mythread = Thread.CurrentThread;
            for (int i = 1; i < 5; i++)
            {
                Thread newsthread = new Thread(Print1);
                newsthread.Name = $"{i} th thread";
                newsthread.Start();
            }
            Mythread.Join();
            //function nmadur()
        }
        public static void LockSynchronize()
        {
            object obj = new();
            Thread Mythread = Thread.CurrentThread;
            Thread newsthread;
            for (int i = 1; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    newsthread = new Thread(LockPrint);
                }
                else
                {
                    newsthread = new Thread(LockPrint2);
                }
                newsthread.Name = $"{i} th thread";
                newsthread.Start();


            }



            void LockPrint()
            {

                lock (obj)
                {
                    int x = 1;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " " + x);
                        x++;
                    }


                }
            }
            void LockPrint2()
            {
                lock (obj)
                {
                    int x = 1;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " " + x);
                        x++;
                    }

                }

            }
        }

        public static void MonitorUsing()
        {
            int x = 0;
            object locker = new();  // объект-заглушка
                                    // запускаем пять потоков
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"thread {i} th => ";
                myThread.Start();
            }

            void Print()
            {
                bool acquiredLock = false ;
                try
                {
                

                    Monitor.Enter(locker, ref acquiredLock);
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                        x++;
                    }
                }

                finally
                {
                    if(acquiredLock) Monitor.Exit(locker);
                }
            }
        }
     

        static void Print1()
        {
            int x = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + x);
                x++;
            }
        }




        static void Print()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " => " + i);
            }

        }







    }
}
