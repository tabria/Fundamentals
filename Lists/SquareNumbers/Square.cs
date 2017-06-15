using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Square
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sqrtNumbers = new List<int>();

            for(int i =0; i<numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    sqrtNumbers.Add(numbers[i]);
                }
            }

            sqrtNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", sqrtNumbers));
        }
    }
}
