using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hideout
{
    class Program
    {
        static void Main()
        {
            string map = Console.ReadLine();

            while (true)
            {
                string[] clues = Console.ReadLine().Split(' ').ToArray();
                char clueChar = clues[0][0];
                int clueCount = int.Parse(clues[1]);
                var indexHideout = map.IndexOf(new string(clueChar, clueCount));

                if (indexHideout != -1)
                {
                    string regex = $"[\\{clueChar}]{{{clueCount},}}";
                    var matchCount = Regex.Match(map, regex).Length;
                    Console.WriteLine($"Hideout found at index {indexHideout} and it is with size {matchCount}!");
                    break;
                }
            }
        }
    }
}
