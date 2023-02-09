using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_4_FIles_Directory.HomeWork
{
    internal class SearchFile
    {
          public static void Start()
        {
            string path = "C:\\Users\\Windows_10\\Desktop\\MyFiles";

            foreach (var item in MatchedNames("Jamshid",path))
            {
                Console.WriteLine(item);
            }

        }
        static List<string> MatchedNames(string match,string path)
        {
            List<string> result = new List<string>();
            DirectoryInfo directoryInfo= new DirectoryInfo(path);
            foreach (var item in directoryInfo.EnumerateFiles())
            {
                if (item.Name.Contains(match))
                    result.Add(item.Name);
            }
            foreach (var item in directoryInfo.EnumerateDirectories())
            {
                if(item.Name.Contains(match))
                    result.Add(item.Name);
                foreach (var InnerItem in item.GetFiles())
                {
                    if(InnerItem.Name.Contains(match))
                        result.Add(InnerItem.Name); 
                }
            }
            return result;  

        }
        
        
    }
}
