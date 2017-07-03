using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = Console.ReadLine();
            string regex = @"((^|(?<=\s))[A-Za-z0-9][\w.-]+)@([A-Za-z]+([.\-]|[A-Za-z])+\.[A-Za-z]+)";

            MatchCollection emailString = Regex.Matches(inputText, regex);

            string[] emails = emailString.Cast<Match>().Select(s => s.Value).ToArray();

            Console.Write(string.Join(Environment.NewLine, emails));
            Console.WriteLine();
        }
    }
}
