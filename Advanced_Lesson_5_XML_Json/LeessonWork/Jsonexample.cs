using Modul_3.Advanced_Lesson_5_XML_Json.HomeWork;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.ExceptionServices;
using System.Text.Json.Nodes;

namespace Modul_3.Advanced_Lesson_5_XML_Json.LeessonWork
{
    internal class Jsonexample
    {
        readonly static string path = "C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_5_XML_Json\\HomeWork\\firstJson.json";
        public static void Start()
        {
            try
            {
                Vehicle car = new Vehicle()
                {
                    Name = "car",
                    NumberOfsets = 4,
                    regions = new List<string>() { "Andijan", "kharazm", "bukhara", "khiva", "kashkadarya" }
                };

                Vehicle plane = new Vehicle()
                {
                    Name="Plane",
                    NumberOfsets = 250,
                    regions =new List<string>() { "newYork","manhetten","kanada","brusli"}

                };

                string newstr=JsonConvert.SerializeObject(car,Formatting.Indented);
                string newstr2=JsonConvert.SerializeObject(plane,Formatting.Indented);

                



                using (StreamWriter write = new StreamWriter(path))
                {
                    write.WriteLine(newstr2);

                }
                
           

            } 
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
       
        }



    }
    public class Vehicle
    {

        public List<string>?  regions { get; set; }

        public string? Name { get; set; }
        public int NumberOfsets { get; set; }


    }

}
