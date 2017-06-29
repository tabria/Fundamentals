using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Shake
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string pattern = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            while (true)
            {
                if (string.IsNullOrEmpty(pattern))
                {
                    break;
                }

                int firstMatch = str.IndexOf(pattern);
                int secondMatch = firstMatch != -1 ? str.LastIndexOf(pattern) : -1;

                if (secondMatch == firstMatch)
                {
                    break;
                }

                sb.Append(str);
                sb.Remove(firstMatch, pattern.Length);
                var secondMatchAdjust = secondMatch - pattern.Length;
                sb.Remove(secondMatchAdjust, pattern.Length);
                str = sb.ToString();
                sb.Clear();

                sb.Append(pattern);
                sb.Remove(pattern.Length / 2, 1);
                pattern = sb.ToString();
                sb.Clear();
                Console.WriteLine("Shaked it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(str);

        }
    }
}
