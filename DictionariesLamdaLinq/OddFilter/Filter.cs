using System;
using System.Collections.Generic;
using System.Linq;

namespace OddFilter
{
    class Filter
    {
        static void Main()
        {
            List<int> intArr = Console.ReadLine()
                                      .Split(' ')
                                      .Select(int.Parse)
                                      .Where(x=>x % 2 ==0)
                                      .ToList();

            intArr = intArr.Select(x=> (x > intArr.Average() ? x+1 : x-1) ).ToList();

            Console.WriteLine(string.Join(" ",intArr));
        }
    }
}
