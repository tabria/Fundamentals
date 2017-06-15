using System;
using System.Collections.Generic;
using System.Linq;


namespace CountNumbers
{
    class NumbersCount
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Dictionary<int, int> countedNumbers = new Dictionary<int, int>();

            numbers.Sort();
            for(int i=0; i<numbers.Count; i++)
            {
                int count = 1;
                try
                {
                    count = countedNumbers[numbers[i]] + 1;
                    countedNumbers[numbers[i]] = count;

                }
                catch
                {
                    countedNumbers.Add(numbers[i], count);
                }
                
            }

            foreach(var kvp in countedNumbers)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            
        }
    }
}
