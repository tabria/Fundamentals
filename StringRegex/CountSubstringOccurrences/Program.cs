using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string needle = Console.ReadLine().ToLower();

            int count = 0;
            int index = -1;
            while ((index = text.IndexOf(needle, index + 1)) != -1)
            {
                  count++;
            }
            Console.WriteLine(count);
        }
    }
}
