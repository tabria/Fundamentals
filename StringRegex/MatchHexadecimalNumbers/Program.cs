using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main()
        {

            string regex = @"\b(?:0x)?[A-F0-9]+\b";
            string hexInput = Console.ReadLine();

            MatchCollection hexNumbers = Regex.Matches(hexInput, regex);

            string[] validHex = hexNumbers.Cast<Match>().Select(s => s.Value).ToArray();
            Console.WriteLine(string.Join(" ", validHex));

        }
    }
}
