using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlyLetters
{
    class Program
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            string regex = @"(?:[^\d]*)(?:\d+)(?<letter>[A-Za-z])";

            while (true)
            {
                string letter = Regex.Match(inputText, regex).Groups["letter"].Value.ToString();
                if (string.IsNullOrEmpty(letter))
                {
                    break;
                }
                string regexReplace = @"(^[^\d]*)(\d+)(.*)";
                inputText = Regex.Replace(inputText, regexReplace, m => m.Groups[1].Value + letter + m.Groups[3].Value);
            }

            Console.WriteLine(inputText);
        }
    }
}
