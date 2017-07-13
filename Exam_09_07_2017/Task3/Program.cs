using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {

            string didimonRegex = @"([^-a-zA-Z]+)";
            string bojomonRegex = @"([a-zA-Z]+-[a-zA-Z]+)";

            var inputString = Console.ReadLine();
            var count = 0;
            while (true)
            {
                string matchRegex = count % 2 == 0 ? didimonRegex : bojomonRegex;
                var match = Regex.Match(inputString, matchRegex);
                if (match.Success)
                {
                    string result = match.Groups[0].Value;
                    Console.WriteLine(result);
                    int index = inputString.IndexOf(result);
                    inputString = inputString.Substring(index);
                    count++;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
