using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            char[] separator = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            string[] words = text.Split(separator);

            var result = words.Where(w => w != "")
                              .Where(w => w.Length < 5)
                              .Distinct()
                              .OrderBy(w => w);

            Console.WriteLine(string.Join(", ", result));         

        }
    }
}
