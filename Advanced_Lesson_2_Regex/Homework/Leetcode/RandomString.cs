using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework.Leetcode
{
    internal class RandomString
    {
        public static void UniqueMorseRepresentations(string[] words)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>() 
            { 
                    ['a']=".-", ['b']= "-...",['c']= "-.-.",['d']= "-..",['e'] =".",
                ['f'] = "..-.", ['g']="--.",['h']= "....",['i']= "..",['j']= ".---", ['k']="-.-",
                ['l']=".-..", ['m']="--",['n']= "-.", ['o']="---",['p'] =".--.",['q']= "--.-",
                ['r']=".-.",['s']= "...", ['t']="-", ['u']="..-",['v']= "...-", ['w']=".--",
                ['x']= "-..-", ['y']="-.--", ['z']="--.."
            };
            HashSet<string> morses = new();
            foreach (string word in words)
            {
                string str = "";
                for (int i = 0; i < word.Length; i++)
                    str += dic[word[i]];
                morses.Add(str);
            }
            Console.WriteLine( morses.Count);



    }
    }
}
