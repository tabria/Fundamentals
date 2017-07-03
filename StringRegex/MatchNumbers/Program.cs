using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main()
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string numbers = Console.ReadLine();

            MatchCollection nums = Regex.Matches(numbers, regex);

            foreach (Match number in nums)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
