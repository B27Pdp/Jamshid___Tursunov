using Modul_3.Advanced_Lesson_2_Regex.Homework.EventDelegate;
using System.Text.RegularExpressions;

namespace Modul_3.Advanced_Lesson_4_FIles_Directory.HomeWork
{
    internal class Registration
    {
        public static void Start()
        {
            List<Person> people= new List<Person>();    
            DirectoryInfo? myDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            myDirectory = myDirectory?.Parent?.Parent?.Parent;
            DirectoryInfo? Myfiles = new DirectoryInfo(myDirectory + "\\Advanced_Lesson_4_FIles_Directory\\HomeWork\\MyFiles");
            //Console.WriteLine(Myfiles);
            Myfiles.Create();
            FileInfo? createdFile=new FileInfo(Myfiles.FullName);
            //List<DirectoryInfo> accounts = new List<DirectoryInfo>(); 

            Console.WriteLine("1. Sign In => ");
            Console.WriteLine("2. Login In => ");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (number)
            {
                case 1:
                    string? Name, LastName, GoogleAccount, UserName, Password; int? age;
                    while (true)
                    {
                        Console.Write("create UserName=> ");
                        UserName = Console.ReadLine();
                        if (!File.Exists(Myfiles + $@"\{UserName}Account.txt"))
                        {
                            createdFile = new FileInfo(Myfiles + $"\\{UserName}Account.txt");
                            createdFile.Create().Close();
                            Console.WriteLine("Username is taken succesfully");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("this username is already taken");
                            Console.WriteLine("press enter to try again. ");
                            Console.ReadKey();
                            Console.Clear();

                        }
                    }
                    while (true)
                    {
                        Console.Write("Input Your name=> ");
                        Name = Console.ReadLine();
                        if (Regex.IsMatch(Name, "^[A-Z][a-z]"))
                        {
                            Console.WriteLine("Name took Succesfully. ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid name. press Enter to try again. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    while (true)
                    {
                        Console.Write("Input Your Last Name => ");
                        LastName = Console.ReadLine();
                        if (Regex.IsMatch(LastName, "^[A-Z][a-z]"))
                        {
                            Console.WriteLine("Last Name took Succesfully. ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid LastName. press Enter to try again. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    while (true) 
                    {
                        Console.Write("Create Password=> ");
                        Password = Console.ReadLine();
                        if (Regex.IsMatch(Password, @"[a-z]*[A-Z]*\d*[\!-/]*") && Password.Length >= 8)
                        {
                            Console.WriteLine("Password taken successfully. ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("a Password must contain at least 8 characters , one punctuation, a lowercase letter,");
                            Console.WriteLine("upper case letter and a  digit  ");
                            Console.WriteLine("Press enter to try again. ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                    while (true)
                    {
                        Console.Write("Input your age => ");
                        try
                        {
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("succesfully taken. ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    }
                    while (true)
                    {
                        Console.Write("Input your Google Account => ");
                        GoogleAccount = Console.ReadLine();
                        if (Regex.IsMatch(GoogleAccount, @"\@gmail\.(com|ru|uz|net)$"))
                        {
                            Console.WriteLine("Google account taken succesfully. ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalid google account. ");
                            Console.WriteLine("press enter to try again. ");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        

                    }
                    Person person = new()
                    {
                        ID = Guid.NewGuid(), Name = Name, age=age,LastName=LastName,GoogleAccount=GoogleAccount,
                        Password=Password,UserName=UserName

                    };
                    
                    using (StreamWriter write = createdFile.AppendText())

                    {
                        write.WriteLine("User ID: " + person.ID);
                        write.WriteLine("User Name :" + person.UserName);
                        write.WriteLine("Name :" +person.Name );
                        write.WriteLine("last Name :" + person.LastName);
                        write.WriteLine("Age :" + person.age);
                        write.WriteLine("Google Account :" + person.GoogleAccount);
                        write.WriteLine(person.Password);


                    }
                    people.Add(person);
                   
                    break;
                case 2:
                    while (true)
                    {

                        Console.Write("Input UserName => ");
                        string username = Console.ReadLine();
                        Console.Write("Input Password => ");
                        string password = Console.ReadLine();


                        if (!Myfiles.GetFiles().Any(x => x.Name == $"{username}Account.txt"))
                            Console.WriteLine("there is no found user with this user name. ");
                        else
                        {
                            if (File.ReadAllLines(Myfiles + $"\\{username}Account.txt").Last() == password)
                            {
                                Console.WriteLine("Succesfully Logged In. ");
                                Console.Write("\n\n"+File.ReadAllText(Myfiles + $"\\{username}Account.txt"));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid password. ");
                            }
                        }
                                Console.WriteLine("try again. ");
                                Console.ReadKey();

                    }
                  
                    break;
                default: Console.WriteLine("Invalid Input. "); break;


            }
          
        }




    }
}
