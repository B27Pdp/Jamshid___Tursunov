using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork.Skoring
{
    internal class Shop
    {
        static readonly string IIBpath = "C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_6_Threads_Asynthrons_Parallel\\HomeWork\\Skoring\\IIBData.json";
        static readonly string Spath = "C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_6_Threads_Asynthrons_Parallel\\HomeWork\\Skoring\\UsersData.json";
        static readonly string Cpath = "C:\\Users\\Windows_10\\source\\repos\\Modul_3\\Advanced_Lesson_6_Threads_Asynthrons_Parallel\\HomeWork\\Skoring\\ClientsData.json";
        static List<Person>? people = new();
        static List<User>? users = new();
        static List<Item> items = new()
        {
            new(){ ID=1,Name="SmartPhone",Price=2000000,Guarantee=1},
            new(){ ID=2,Name="Laptop",Price=8000000,Guarantee=2},
            new(){ ID=3,Name="Printer",Price=4000000,Guarantee=1},
            new(){ ID=4,Name="Projecter",Price=5000000,Guarantee=2},
            new(){ ID=5,Name="Mouse",Price=50000,Guarantee=1},

        };

        static List<Client> clients = new();
       

        async static Task IIBSerializing()
        {
            await Task.Run(() =>
            {
                Person person1 = new(1, "Jamshid", "AB1234524", 23, true);
                Person person2 = new(2, "Abror", "AB1453543", 18, false);
                Person person3 = new(3, "Javlon", "AB1232324", 19, false);
                Person person4 = new(4, "Sardor", "AB5434524", 25, true);
                Person person5 = new(5, "Ulugbek", "AB1134524", 26, true);
                people = new()
            {
                person1,
                person2,
                person3,
                person4,
                person5
            };
                File.WriteAllText(IIBpath, JsonConvert.SerializeObject(people, Formatting.Indented));
            });
        }
        async static Task CSerializing()
        {
            await Task.Run(() =>
            {
                clients = new()
            {
                new(1,"Jamshid","AB1234524",23,ActivitionDuration.MoreThanTwoYear,PaymentHistory.FullyPayment),
            new(2, "Abror", "AB1453543", 18,ActivitionDuration.LessThanAYear,PaymentHistory.PartialPayment),

            new(3, "Javlon", "AB1232324", 19, ActivitionDuration.MoreThanTwoYear, PaymentHistory.MissedPayment),

            new(4, "Sardor", "AB5434524", 25, ActivitionDuration.LessThanSixMonth, PaymentHistory.MissedPayment),

            new(5, "Ulugbek", "AB1134524", 26, ActivitionDuration.LessThanTwoYear, PaymentHistory.FullyPayment),


        };
                File.WriteAllText(Cpath, JsonConvert.SerializeObject(clients, Formatting.Indented));
            });
        }

        async static Task SSerializing()
        {
            await Task.Run(() =>
            {
                users = new()
            {
               new(1,"Jamshid","AB1234524",23,2500000,0),
            new(2, "Abror", "AB1453543", 18,15000000,20000),

            new(3, "Javlon", "AB1232324", 19,1000000,100000),

            new(4, "Sardor", "AB5434524", 25,25000000,20000),

            new(5, "Ulugbek", "AB1134524", 26,18000000,10000)


        };
                File.WriteAllText(Spath, JsonConvert.SerializeObject(users, Formatting.Indented));
            });

        }

        public static  void Run()
        {
            if (!File.Exists(IIBpath))
            {
                File.Create(IIBpath).Dispose();
                IIBSerializing();
            }
            else
            {
                Task.Run(() => { people = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(IIBpath)) ?? new(); });
            }
            if (!File.Exists(Spath))
            {
                File.Create(Spath).Dispose();
                SSerializing();
            }
            else
            {
                Task.Run(() => {
                    users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(Spath)) ?? new();
                });
            }
            if (!File.Exists(Cpath))
            {
                File.Create(Cpath).Dispose();
                CSerializing();
            }
            else
            {
                Task.Run(() => {
                    clients = JsonConvert.DeserializeObject<List<Client>>(File.ReadAllText(Cpath)) ?? new();
                });
            }
            Client? currentClient = new Client();
            Console.Write("Enter PassPort Seria number: ");
            string? PassportDataa = Console.ReadLine();
            if(ClientFind(PassportDataa)!=null)
            {
                currentClient = ClientFind(PassportDataa) ?? new Client();

            }
            else Console.WriteLine(" there is no client with passport number.  ");

            Person? CurrentPerson = PersonFind(currentClient.PassportData).Result;
            User? CurrentUser = UserFind(currentClient.PassportData).Result;
            Console.WriteLine("thanks for giving information. ");
             Console.WriteLine($"your available contract is for {Scoring(CurrentUser,CurrentPerson,currentClient)} som. ");



        }
        static double Calculate(List<Item> items)
        {
            double x = 0;
            items.ForEach(item => x += item.Price);
            return x;

        }
         static Client?  ClientFind(string? Passport)
        {
            
                Client? client=new Client();
            JArray clientss = JArray.Parse(File.ReadAllText(Cpath));
            JToken? PassportData = clientss.FirstOrDefault(x => (string?)x["PassportData"] == Passport);
                if (PassportData != null)
                    return PassportData.ToObject<Client>();
                return null;
        }
        async static Task<Person?> PersonFind(string PassportDataa)
        {
                Person? FoundPerson = new Person();
            await Task.Run(() =>
            {
                JArray persons = JArray.Parse(File.ReadAllText(IIBpath));
                JToken? PassportData = persons.FirstOrDefault(x => (string?)x["PassportData"] == PassportDataa);
                if (PassportData != null)
                {

                    FoundPerson= PassportData.ToObject<Person>();

                }
                else Console.WriteLine("there is person with this passport data.");
            });
            return FoundPerson;

        }
        async static Task<User?> UserFind(string PassportDataa)
        {
                User? FoundUser = new User();
            await Task.Run(() =>
            {
                JArray userss = JArray.Parse(File.ReadAllText(Spath));
                JToken? PassportData = userss.FirstOrDefault(x => (string?)x["PassportData"] == PassportDataa);
                if (PassportData != null)
                {

                    FoundUser= PassportData.ToObject<User>();


                }
                  else  Console.WriteLine(" there is no user with this Passport data. ");
            });
            return FoundUser;


        }
      
        static double Scoring(User? user, Person? person, Client? client)
        {
            double Sum = 0;
            if (client.activitionDuration == ActivitionDuration.LessThanSixMonth)
            {
                Sum += 500000;
            }
            else if (client.activitionDuration == ActivitionDuration.LessThanAYear)
            {
                Sum += 1000000;
            }
            else if (client.activitionDuration == ActivitionDuration.LessThanTwoYear)
            {
                Sum += 5000000;
            }
            else Sum += 10000000;
            if (user.Salary <= 5000000)
            {
                Sum += user.Salary * 5;
            }
            else if (5000000 < user.Salary && user.Salary <= 10000000)
            {
                Sum += user.Salary * 7;
            }
            else Sum += user.Salary * 10;
            Sum -= user.Debt * 3;

            if (person.IsMarried) Sum -= 2500000;
            if (client.paymentHistory == PaymentHistory.MissedPayment)
            {
                Sum = 0;
            }
            else if (client.paymentHistory == PaymentHistory.PartialPayment)
            {
                Sum *= 0.3;
            }
            else Sum *= 1.1;
            return Sum;
        }

    }
}
