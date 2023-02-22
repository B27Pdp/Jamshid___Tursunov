namespace Modul_3.Advanced_Lesson_4_FIles_Directory.LessonWork
{
    internal class Teacherswork
    {


        public static void Start()
        {
            string path = Directory.GetCurrentDirectory().ToString();
            DirectoryInfo? thisDir = new DirectoryInfo(path);

            thisDir = thisDir?.Parent?.Parent?.Parent;

            //thisDir?.CreateSubdirectory("IPerson\\Employee");
            //thisDir?.CreateSubdirectory("IPerson\\Student");
            //Directory.Delete(thisDir.FullName + "\\IPerson\\Employee");
            //Directory.Delete(thisDir.FullName + "\\IPerson\\Student");
            string[] objName = new string[] { "PersonData1", "PersonData2", "PersonData3" };
            thisDir = new DirectoryInfo(thisDir.FullName + "\\IPerson");
            foreach (string item in objName)
            {
                if (!File.Exists(thisDir.FullName + $"\\{item}.txt"))
                {
                    File.Create(thisDir.FullName + $"\\{item}.txt").Dispose();
                }
            }

            List<Person> people = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person() { Id = i + 1, Name = "Eshmat" + i });
                Console.WriteLine(people[i]);
            }
            FileInfo[] personDatas = thisDir.GetFiles();

            using (StreamWriter writer = personDatas[0].CreateText())
            {
                people.ForEach(person =>
                {
                    writer.Write(person);
                });
            }
            people.ForEach(person =>
            {
                File.AppendAllText(personDatas[1].FullName, person.ToString());
            });






        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\n";
        }
    }


}
