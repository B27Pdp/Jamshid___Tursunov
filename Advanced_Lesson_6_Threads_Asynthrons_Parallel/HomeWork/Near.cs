using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Modul_3.Advanced_Lesson_6_Threads_Asynthrons_Parallel.HomeWork
{
    internal class Near
    {
        static readonly string path = @"C:\Users\Windows_10\source\repos\Modul_3\Advanced_Lesson_6_Threads_Asynthrons_Parallel\HomeWork\Information.json";
        public static void Run()
        {
            SClass s1 = new()
            {
                x1 = 3,
                x2 = 4,
                x3 = 8,
                y = 1
            };
            SClass s2 = new()
            {

                x1 = 5,
                x2 = 1,
                x3 = 7,
                y = 1
            };
            SClass s3 = new()
            {
                x1 = 4,
                x2 = 2,
                x3 = 7,
                y = 1
            };
            SClass s4 = new()
            {

                x1 = 3,
                x2 = 1,
                x3 = 4,
                y = 2
            };
            SClass s5 = new()
            {
                x1 = 5,
                x2 = 1,
                x3 = 8,
                y = 2
            };
            SClass s6 = new()
            {
                x1 = 6,
                x2 = 2,
                x3 = 9,
                y = 3
            };
            SClass s7 = new()
            {
                x1 = 8,
                x2 = 1,
                x3 = 7,
                y = 3
            };
            List<SClass> list = new()
            {

                s1,s2,s3,s4,s5,s6,s7
            };

            string JsonFormat = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.Create(path).Close();
            File.WriteAllText(path, JsonFormat);
            JArray array = JArray.Parse(File.ReadAllText(path));
            List<JToken> listt = new();
            foreach (var item in array)
            {
                listt.Add(item);
            }
            JToken swap;
            for (int i = 0; i < listt.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((double)listt[i]["y"] < (double)listt[j]["y"])
                    {
                        swap = listt[i];
                        listt[i] = listt[j];
                        listt[j] = swap;
                    }
                }
            }

            List<double[]> SumOfTheSameClass = new();
            double x1 = 0, x2 = 0, x3 = 0, s = 0;
            //listt.ForEach(Console.WriteLine);
            //SumOfTheSameClass.Add(new int[] {})
            if ((int)listt[0]["y"] != (int)listt[1]["y"])
            {
                SumOfTheSameClass.Add(new double[] { (double)listt[0]["x1"], (double)listt[0]["x2"], (double)listt[0]["x3"], (int)listt[0]["y"] });

            }
            else
            {
                s++;
                x1 += (double)listt[0]["x1"];
                x2 += (double)listt[0]["x2"];
                x3 += (double)listt[0]["x3"];
            }
            for (int i = 1; i < listt.Count; i++)
            {

                if ((int)listt[i - 1]["y"] == (int)listt[i]["y"])
                {
                    s++;
                    x1 += (double)listt[i]["x1"];
                    x2 += (double)listt[i]["x2"];
                    x3 += (double)listt[i]["x3"];
                }
                else
                {
                    SumOfTheSameClass.Add(new double[] { x1 / s, x2 / s, x3 / s, (int)listt[i - 1]["y"] });
                    x1 = (double)listt[i]["x1"]; x2 = (double)listt[i]["x2"]; x3 = (double)listt[i]["x3"]; s = 1;

                }
            }
            SumOfTheSameClass.Add(new double[] { x1 / s, x2 / s, x3 / s, (int)listt.Last()["y"] });
            string str = Console.ReadLine();
            string[] stringNums = str.Split(' ');
            double[] IntNums = { Convert.ToInt32(stringNums[0]), Convert.ToInt32(stringNums[1]), Convert.ToInt32(stringNums[2]), };
            double MinResult = 100; int MinGroup = 0;
            for (int i = 0; i < SumOfTheSameClass.Count; i++)
            {
                double result = Math.Sqrt(Math.Pow((IntNums[0] - SumOfTheSameClass[i][0]), 2) + Math.Pow((IntNums[1] - SumOfTheSameClass[i][1]), 2) + Math.Pow((IntNums[2] - SumOfTheSameClass[i][2]), 2));
                if (result < MinResult)
                {
                    MinResult = result;
                    MinGroup = (int)SumOfTheSameClass[i][3];
                }

            }
            Console.WriteLine("result group => " + MinGroup);
            




        }


    }
}
