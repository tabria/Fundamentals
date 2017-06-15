using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    class SortNums
    {
        static void Main()
        {

            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));

        }
    }
}
