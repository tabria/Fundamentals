using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceEqualElements
{
    class MaxSequence
    {
        static void Main()
        {
            List<int> intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> longestSequence = new List<int> { intList[0], 1};

            int count = 1;
            int prevValue = intList[0];
            for (int i=1; i< intList.Count; i++)
            {
                if (intList[i] == prevValue)
                {
                    count++;
                    if (count > longestSequence[1])
                    {
                        longestSequence[0] = intList[i];
                        longestSequence[1] = count;
                    }
                }
                else
                {
                    count = 1;
                    prevValue = intList[i];
                }
            }

            for (int i = 0; i < longestSequence[1]; i++)
            {
                Console.Write($"{longestSequence[0]} ");
            }
            Console.WriteLine();
        }
    }
}
