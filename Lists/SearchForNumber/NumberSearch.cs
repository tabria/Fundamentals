using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForNumber
{
    class NumberSearch
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numbersInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string found = "NO!";
            for(int i= numbersInfo[1]; i< numbersInfo[0]; i++)
            {
                if (numbers[i] == numbersInfo[2])
                {
                    found = "YES!";
                    break;
                }
            }
            Console.WriteLine(found);
        }
    }
}
