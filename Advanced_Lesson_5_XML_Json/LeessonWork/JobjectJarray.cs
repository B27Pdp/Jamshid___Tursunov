using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_5_XML_Json.LeessonWork
{
    internal class JobjectJarray
    {
        
        public static bool Update(string path,List<People> list)
        {
            bool isDone = false;
            if (File.Exists(path))
            {
                JObject company=JObject.Parse(File.ReadAllText(path));

                JArray? friends = company["friends"] as JArray;






                return true;
            }
            return false;



        }


    }
}
