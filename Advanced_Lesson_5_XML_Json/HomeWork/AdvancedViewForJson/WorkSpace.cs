using Modul_3.Advanced_Lesson_5_XML_Json.LeessonWork;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Modul_3.Advanced_Lesson_5_XML_Json.HomeWork.AdvancedViewForJson
{
    internal class WorkSpace
    {
        public static void create(string path, Student student)
        {
            if(!File.Exists(path))
            {
            File.Create(path).Close();
            }
            string JsonString =JsonConvert.SerializeObject(student, Formatting.Indented);
            File.WriteAllText(path, $"[{JsonString}]");

            
        }
        public static void Read(string path)
        {
            string Jsonstring=File.ReadAllText(path);
            Console.WriteLine(Jsonstring);

        }
        public static void Add(Student student, string path)
        {
            JArray array = JArray.Parse(File.ReadAllText(path));
            JToken? newelement = array.FirstOrDefault(x => (Guid?)x["ID"] == student.ID);
            if(newelement == null) 
            {
                JToken jtoken=JToken.FromObject(student);
                array.Add(jtoken);
            }
            File.WriteAllText(path, array.ToString());




        }
        public static void Update(Student OldStudent, Student NewStudent, string path)
        {
            JArray array = JArray.Parse(File.ReadAllText(path));

            JToken? Old=array.FirstOrDefault(x => (Guid?)x["ID"]==OldStudent.ID);
            if(Old!=null)
            {
                array.Remove(Old);
                NewStudent.ID=OldStudent.ID;
                JToken news = JToken.FromObject(NewStudent);
                array.Add(news);
            }
            else Console.WriteLine("there is no Student with this ID number. ");
            File.WriteAllText(path, array.ToString());


        }
        public static string? ReadByUniversityName(string UniversityName,string path)
        {
            JArray array = JArray.Parse(File.ReadAllText(path));
            JToken? Old = array.FirstOrDefault(x => (string?)x["university"]["Name"] == UniversityName);
            if(Old!=null) 
                return (string?)Old["Name"];
           
            return "there is no student who studis at this university";
             

        }
        public static List<string>? ReadAllByUniversityName(string UniversityName,string path)
        {
            JArray array = JArray.Parse(File.ReadAllText(path));
            List<JToken>? Old = array.Where(x => (string?)x["university"]["Name"] == UniversityName).ToList();
            if (Old.Count != 0)
            {
                List<string?>? list = new();
                foreach (JToken item in Old)
                {
                    list.Add((string?)item["Name"]);
                }
                return list;

            }
            return new List<string>() { "there is no student  who studis at this university" };
              

        }
        public static void UpdateByUniversityName(string Name,string NewUniversityName,string path)
        {
            JArray array = JArray.Parse(File.ReadAllText(path));
            JToken? token = array.FirstOrDefault(x => (string?)x["Name"] == Name);
            if (token!=null)
            {
                token["university"]["Name"] = NewUniversityName;
                File.WriteAllText(path, array.ToString());
                Console.WriteLine("university name successfully changed. ");
            }
            else Console.WriteLine("our DataBase is not involved in this Student. ");
        }

        public static List<string> ReadAllExsistSciences(string science,string path)
        {
            List<string> Names = new List<string>();
            JArray array = JArray.Parse(File.ReadAllText(path));
            List<JToken>? contains=array.Where(x => x["sciences"].Contains((JToken)science)).ToList();
            foreach (JToken item in contains)
            {
                Names.Add((string)item["Name"]);
            }
            return Names;

        }




    }
}
