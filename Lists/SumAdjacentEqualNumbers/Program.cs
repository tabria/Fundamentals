using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            
            for(int i = 0; i<numbers.Count; i++)
            {
                if (i < numbers.Count - 1 && numbers[i] == numbers[i+1])
                {
                    decimal sum = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    numbers[i] = sum;
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
