namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork
{
    internal class Asynchronize
    {
        public  static  void Run()
        {
            Console.WriteLine("Run function started. ");
            // EnormousLoop();
            Console.WriteLine(GenericFunction());
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + "  Main thread. ");
            }
            Console.WriteLine("run function finished. ");
            Console.ReadKey();
        }
          async static Task EnormousLoop()
         {
           
            Console.WriteLine("task function started. ");
            await Task.Run(Print);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + "-Enourmuos loop function");
            }
            Console.WriteLine("task funtion finished. ");
         }
        static void Print()
        {
            Console.WriteLine("Print function started. ");
            for (int i = 0; i < 100; i++)
            {
            Console.WriteLine(i+" =>Print function ");
            }
            Console.WriteLine("Print funtion finished. ");
        }
        public static void Func()
        {
            Console.WriteLine(" there are few technologies and we couldn't  ever be better. ");
        } 

        async static Task<string> GenericFunction()
        {
            Console.WriteLine("function has started. ");
             await Task.Run(() =>
            {
                Thread.CurrentThread.Priority = ThreadPriority.Highest;
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId+" inner of Run "+i);
                }
               

            });
            Console.WriteLine("my name is Jamshid");
            return "Generic function has finished. ";

        }

    }
}
