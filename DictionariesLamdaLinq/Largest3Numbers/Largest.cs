using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Largest
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var result = numbers.OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
