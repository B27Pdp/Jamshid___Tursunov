using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Modul_3.Advanced_Lesson_5_XML_Json.HomeWork
{
    internal class EXMCRUD
    {
        public static void Read()
        {
            try
            {
                XmlDocument myexml = new XmlDocument();
                 string path="C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_5_XML_Json\\HomeWork\\newXMLfile.xml";
                myexml.Load(path);
                string path2 = "C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_5_XML_Json\\HomeWork\\newXMLfile2.xml";
                XmlElement? element = myexml.DocumentElement;




                if (element != null)
                {
                    foreach (XmlNode item in element)
                    { 
                        foreach (XmlNode innneritem in item)
                        {
                            Console.WriteLine(innneritem?.Attributes?.GetNamedItem("name")?.Value);
                            Console.WriteLine(innneritem?.Name);
                            foreach (XmlNode? item3 in innneritem)
                            {
                                Console.Write(item3?.Attributes?.GetNamedItem("name") + "  ");
                                Console.Write(item3.Name + "  ");
                                Console.Write(item3.InnerText + "  ");
                            } 
                            Console.WriteLine();
                        }

                    }
                }
                Console.WriteLine(element?.ChildNodes[2]?.ChildNodes[0]?.ChildNodes[0]?.ChildNodes[0]?.Value);



                //using (StreamWriter write = new StreamWriter(path2))
                //{
                //    write.WriteLine("<people>");
                //    write.WriteLine("<person name=\"abror\">");
                //    write.WriteLine("<age>12</age>");
                //    write.WriteLine("</person>");
                //    write.WriteLine("<person>qodir</person>");
                //    write.WriteLine("</people>");

                //}



                #region serializing
                //Book book1 = new("Atomic Habits", 200);


                //XmlSerializer bookchanger = new XmlSerializer(typeof(Book));


                //using (FileStream newfile = new FileStream(path2, FileMode.OpenOrCreate))
                //{

                //    bookchanger.Serialize(newfile, book1);
                //    Console.WriteLine("you have serialized File");
                //}


                //using (FileStream deserialize = new(path2, FileMode.OpenOrCreate))
                //{

                //    Book newbook = bookchanger.Deserialize(deserialize) as Book ?? new();
                //    Console.WriteLine(newbook.Name);
                //    Console.WriteLine(newbook.NUmberOfPages);
                //    Console.WriteLine(newbook.Type);

                //}
                #endregion





            }
            catch (Exception e) {

                Console.WriteLine(e.Message);
            }

        }

        public static void Create()
        {

            Car GMM=new Car();
            GMM.first = "Matiz";
            GMM.second = "Spark";
            Car Hyundai = new Car();
            Hyundai.first = "elantra";
            Hyundai.second = "lada";
           
            try
            {
                string path = @"C:\Users\Windows_10\source\repos\Modul_3\Advanced_Lesson_5_XML_Json\HomeWork\create.xml";
                XmlDocument myexml = new XmlDocument();
                myexml.Load(path);
                XmlElement? root = myexml.DocumentElement;
                XmlNode? chevrolet = root?.SelectSingleNode("/Car");
                XmlNode? matiz = myexml.CreateElement("matiz");
                XmlNode? spark = myexml.CreateElement("spark");
                XmlNode? GM = myexml.CreateElement("GM");
                XmlNode? Hyundaii = myexml.CreateElement("Hyundai");
                XmlNode? elantra = myexml.CreateElement("elantra");
                XmlNode? lada = myexml.CreateElement("lada");
                matiz.InnerText = GMM.first.ToString();
                spark.InnerText = GMM.second.ToString();
                GM.AppendChild(matiz);
                GM.AppendChild(spark);
                elantra.InnerText = Hyundai.first;
                lada.InnerText = Hyundai.second;
                Hyundaii.AppendChild(elantra);
                Hyundaii.AppendChild(lada);
                chevrolet.AppendChild(GM);
                chevrolet.AppendChild(Hyundaii);
                myexml.Save(path);
           

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }

        public static void Update()
        {
            string path = @"C:\Users\Windows_10\source\repos\Modul_3\Advanced_Lesson_5_XML_Json\HomeWork\newXMLfile.xml";
            XmlDocument newdoc = new XmlDocument();
            newdoc.Load(path);
           // string Tom = "Tom";
            XmlElement? root = newdoc.DocumentElement;

           

            XmlNode? node = root?.ChildNodes[0]?.ChildNodes[0]?.ChildNodes[0];
            node.InnerText= "this is updated text";
            Console.WriteLine(node.InnerText);
            newdoc.Save(path);






        }
    }
    public class Car
    {
        public string? first;
        public string? second;
    
    
    }


    public class Book
    {
        public Book()
        {

        }
        public Book(string? name, int nUmberOfPages)
        {
            Name = name;
            NUmberOfPages = nUmberOfPages;
        }

        public string? Name { get; set; }

        public int NUmberOfPages { get; set; }

        public string? Type { get; set; } = "detective";
    }



}
