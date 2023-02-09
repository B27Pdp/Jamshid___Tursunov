using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_4_FIles_Directory.LessonWork
{
    internal class DirectoryExample
    {
        public static void Start()
        {


            DirectoryInfo Myfile = new DirectoryInfo("C:\\Users\\Windows_10\\Desktop\\MyFiles\\Myfile.txt");

            Myfile.Create();




        }






    }
}
