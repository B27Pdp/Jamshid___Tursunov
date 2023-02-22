namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork
{
    internal class MultithreadingExamples
    {
        public static void ThreadAtributes()
        {
            int l = 0;
            Thread current = Thread.CurrentThread;
            for (int i = 1; i < 5; i++)
            {
                Thread newthread = new Thread(Print)
                {
                    Name = $"{i} - newthread"

                };
                newthread.Start();
               
            }
         


            void Print()
            {
                  
                l = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " =>  " + l);
                l++;
                }
            }

        }

    }
}
