using System;
using System.Collections.Generic;
using System.Linq;


namespace LongestIncreasingSubsequence
{
    class LIS
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            int count = 0;
            int maxIndex = -1;
            for (int i=0; i < numbers.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for(int k = 0; k<i; k++)
                {
                    if (numbers[i] > numbers[k] && len[k]+1> len[i])
                    {
                        len[i] = len[k] + 1;
                        prev[i] = k;
                    }
                }
                if (count < len[i])
                {
                    maxIndex = i;
                    count = len[i];
                }
            }

            List<int> finalSequence = new List<int>();
            while (maxIndex > -1)
            {
                finalSequence.Add(numbers[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            finalSequence.Reverse();    
            Console.WriteLine(string.Join(" ", finalSequence));

        }
    }
}
