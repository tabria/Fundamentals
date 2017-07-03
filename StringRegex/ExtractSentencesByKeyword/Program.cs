using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main()
        {
            string needle = Console.ReadLine();
            string seachtext = Console.ReadLine();

            string regex = $"[A-Z][^.?!]+\\b{needle}\\b[^.?!]+(?=[?!.])";

            MatchCollection matchedStrings = Regex.Matches(seachtext, regex);

            string[] results = matchedStrings.Cast<Match>().Select(s => s.Value).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, results));

        }
    }
}
