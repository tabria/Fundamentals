using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MorseCodeUpgraded
{
    class Program
    {
        static void Main()
        {
            string[] code = Regex.Split(Console.ReadLine(), @"\|");
            var sum = 0;
            StringBuilder sb = new StringBuilder();
            foreach(var message in code)
            {
                var countZeros = Regex.Replace(message, @"1", "").Length;
                var countOnes = Regex.Replace(message, @"0", "").Length;
                sum = (countZeros * 3) + (countOnes * 5);

                var consecutiveZeros = Regex.Matches(message, @"(0{2,})").Cast<Match>().Sum(m=>m.Length);
                var consecutiveOnes = Regex.Matches(message, @"(1{2,})").Cast<Match>().Sum(m => m.Length);

                sum += consecutiveOnes + consecutiveZeros;

                sb.Append((char)sum);
                sum = 0;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
