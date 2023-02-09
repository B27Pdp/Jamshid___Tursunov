using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_4_FIles_Directory.HomeWork
{
    internal class CopyOfFile
    {
        public static void Start()
        {
            try
            {
                //string path = "C:\\Users\\Windows_10\\Desktop\\MyFiles\\newfile.txt";
                //string newpath = "C:\\Users\\Windows_10\\Desktop\\MyFiles\\second.txt";
                //FileInfo newfile = new FileInfo(path);
                //newfile.CopyTo(newpath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
