using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main()
        {
            string[] rantWords = Regex.Matches(Console.ReadLine(), @"(.+?\d+)+?").Cast<Match>().Select(m => m.Value).ToArray();
            StringBuilder sb = new StringBuilder();

            foreach (var rant in rantWords)
            {
                string digits = Regex.Match(rant, @"\d+").Value;
                string word = Regex.Match(rant, @"^[^\d]+").Value.ToUpper();
                BuildOutput(digits, word, sb);
            }

            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine(sb.ToString());

        }

        public static void BuildOutput(string digits, string word, StringBuilder sb)
        {
            int repeat = int.Parse(digits);
            for (int i = 0; i < repeat; i++)
            {
                sb.Append(word);
            }
        }
    }
}
