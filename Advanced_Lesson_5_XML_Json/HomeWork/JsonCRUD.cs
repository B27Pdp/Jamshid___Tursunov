using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

namespace Modul_3.Advanced_Lesson_5_XML_Json.HomeWork
{
    internal class JsonCRUD
    {

        public static void Create(Student student, string path)
        {
           
            string Jsonstring = JsonConvert.SerializeObject(student, Formatting.Indented);
            using (StreamWriter write = new StreamWriter(path))
            {
                write.WriteLine(Jsonstring);

            }



        }

        public static void Read(string path, ref  Student student)
        {
            string JsonFileStringFormat=File.ReadAllText(path);
            //Console.WriteLine(JsonFileStringFormat);
            using(FileStream deserializing=new FileStream(path,FileMode.Open))
            {
                student = JsonConvert.DeserializeObject<Student>(JsonFileStringFormat) ?? new();

            }

            


        }

        public static void Update( ref string path, string JsonTextToAppend)
        {
            


        }

          
        public class Student
        {
            public Guid ID { get; set; }
            public string? Name { get; set; }
            public int Age { get; set; }
            public List<string>? Sciences { get; set; }

        }


    }
}
