using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
 
namespace Modul_3.Advanced_Lesson_5_XML_Json.LeessonWork
{
    internal class XML_examples
    {
        public static void Start()
        {
            string path = @"C:\Users\Windows_10\source\repos\Modul_3\Advanced_Lesson_5_XML_Json\LeessonWork\xmlfile.xml";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement? children = xmlDocument.DocumentElement;


            foreach (XmlNode item in children)
            {
                Console.WriteLine(item.Attributes.GetNamedItem("name").Value);

                foreach (XmlNode node1 in item)
                {

                    if (node1.Name == "age") Console.WriteLine(node1.InnerText);
                    if (node1.Name == "company") Console.WriteLine(node1.InnerText);


                }

            } 



        }
    }
    class Person
    {
        public string Name { get; set; }

        public int age { get; set; }
        public int id { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }
    }
}



