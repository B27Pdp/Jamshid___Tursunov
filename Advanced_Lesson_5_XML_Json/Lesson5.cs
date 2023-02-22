using Modul_3.Advanced_Lesson_5_XML_Json.HomeWork;
using Modul_3.Advanced_Lesson_5_XML_Json.HomeWork.AdvancedViewForJson;
using Modul_3.Advanced_Lesson_5_XML_Json.LeessonWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_5_XML_Json
{
    internal class Lesson5
    {
            readonly static string path = @"..\..\..\Advanced_Lesson_5_XML_Json\HomeWork\JsonFile.json";
        readonly static string JsonPath = @"..\..\..\Advanced_Lesson_5_XML_Json\LeessonWork\LessonJson.json";
        readonly static string JsonPath2 = @"..\..\..\Advanced_Lesson_5_XML_Json\HomeWork\AdvancedViewForJson\MyJson.json";

        public static void Main5()
        {

            Thread curre = Thread.CurrentThread;
            try
            {
                //XML_examples.Read();
                //EXMCRUD.Read();


                // EXMCRUD.create();
                //EXMCRUD.Add();

                //  Jsonexample.Start();

                //Student Jamshid = new Student()
                //{
                //    Name = "Jamshid",
                //    ID = Guid.NewGuid(),
                //    Age = 23,
                //    Sciences = new List<string>
                //    { "IT", "Maths", "Pythics", "Psychology", "Geography" }
                //};
                //  Student Sardor = new Student();
                //  //JsonCRUD.create(Jamshid,IIBpath);
                ////  JsonCRUD.Read(IIBpath,  ref Sardor);
                //  Console.WriteLine(Sardor.Name);
                //  Console.WriteLine(Sardor.ID);
                //  Console.WriteLine(Sardor.Age);
                //  Console.WriteLine(Sardor?.Sciences[0]);
                University Myuniversity = new()
                {
                    Name = "Uzmu", ID = Guid.NewGuid()
                };
                University Myuniversity2 = new()
                {
                    Name = "TATU", ID = Guid.NewGuid()
                };
                Student student = new Student()
                {
                    ID = Guid.NewGuid(),
                    Name = "Jamshid",
                    gender = Gender.male,
                    Age = 23,
                    university = Myuniversity,
                    sciences = new List<string>()
                {
                    "Maths","IT","Geograpyh", "Psychology","Chemistry"
                }
                };
                Student student2 = new Student()
                {
                    ID = Guid.NewGuid(),
                    Name = "Abror",
                    gender = Gender.male,
                    Age = 22,
                    university = Myuniversity,
                    sciences = new List<string>()
                {
                    "Maths", "Psychology","Chemistry"
                }
                };
                Student student3 = new Student()
                {
                    ID = Guid.NewGuid(),
                    Name = "Sardor",
                    gender = Gender.male,
                    Age = 25,
                    university = Myuniversity2,
                    sciences = new List<string>()
                {
                    "Law","History"
                }
                };

               WorkSpace.create(JsonPath2, student);
                // WorkSpace.Read(JsonPath2);
                 WorkSpace.Add(student2,JsonPath2);
                //Thread secondthread = new Thread(() => WorkSpace.Update(student, student2, JsonPath2))
                //{
                //    Name = "second thread"
                //};


                  WorkSpace.Add(student3,JsonPath2);

                //Console.WriteLine(WorkSpace.ReadByUniversityName("salxoz",JsonPath2));
                // WorkSpace.ReadAllByUniversityName("Uzmu", JsonPath2).ForEach(Console.WriteLine);
                // WorkSpace.UpdateByUniversityName("Jamshid", "Massachuestes international university. ",JsonPath2);
                //WorkSpace.ReadAllExsistSciences("Maths", JsonPath2).ForEach(Console.WriteLine);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

    }
}
