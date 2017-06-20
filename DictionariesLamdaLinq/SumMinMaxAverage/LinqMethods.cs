using System;
using System.Collections.Generic;
using System.Linq;


namespace SumMinMaxAverage
{
    class LinqMethods
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());
            int[] numbers = new int[cycles];

            for (int i=0; i<cycles; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");

        }
    }
}
