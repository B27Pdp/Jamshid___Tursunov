namespace Modul_3.Advanced_Lesson_4_FIles_Directory.HomeWork
{
    internal class DetermineFolder
    {
        public static void Start()
        {

            //string path = "C:\\Users\\Windows_10\\Desktop\\MyFiles";
            //Console.WriteLine(Determine(path));


        }
        static string Determine(string path)
        {

            DirectoryInfo? firstDirectory = new DirectoryInfo(path);
            if (firstDirectory.GetFiles().Length==0 && firstDirectory.GetDirectories().Length == 0)
                return "hech narsa yuq. ";
            else if (firstDirectory.GetDirectories().Length==0)
                return "fayllar bor";
            else if (firstDirectory.GetFiles().Length==0)
                return "Papkalar bor";
            else return "fayllar va papkalar bor. ";



        }



    }
}
