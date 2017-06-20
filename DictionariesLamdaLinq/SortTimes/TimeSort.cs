using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTimes
{
    class TimeSort
    {
        static void Main()
        {
            List<string> times = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", times));

        }
    }
}
