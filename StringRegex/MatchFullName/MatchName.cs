using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class MatchName
    {
        static void Main()
        {

            string regex = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();

        }
    }
}
