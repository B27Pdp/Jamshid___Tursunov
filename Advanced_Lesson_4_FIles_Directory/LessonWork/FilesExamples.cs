using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_4_FIles_Directory.LessonWork
{
    internal class FilesExamples
    {
        public static void Start()
        {

            string path = @"C:\Users\Windows_10\Desktop\MyFiles\fullname.txt";

            FileInfo fileInf = new FileInfo(path);

            // fileInf.Replace("C:\\Users\\Windows_10\\Desktop\\MyFiles\\full.txt", "C:\\Users\\Windows_10\\Desktop\\MyFiles\\extra.txt");
            using (StreamWriter write = fileInf.CreateText())
            {
                write.WriteLine("dfsfsf");
                write.WriteLine("sad");
                write.WriteLine("dfsdsadafsf");
            }



        }


    }
}
