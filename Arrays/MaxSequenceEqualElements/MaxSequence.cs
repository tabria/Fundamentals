using System;
using System.Linq;


namespace MaxSequenceEqualElements
{
    class MaxSequence
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isSequence = false;
            int[] longestEquals = new int[2];
            int count = 0;
            int currentValue = 0;
            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    if (isSequence == false)
                    {
                        currentValue = arr[i];
                        count++;  
                    }
                    count++;
                    isSequence = true;
                }
                else if (arr[i] != arr[i-1] && isSequence == true)
                {
                    isSequence = false;
                    if (longestEquals[1] < count)
                    {
                        longestEquals[1] = count;
                        longestEquals[0] = currentValue;
                    }
                    count = 0;
                }
            }

            if (longestEquals[1] == 0)
            {
                longestEquals[1] = count;
                longestEquals[0] = currentValue;
            }

            for (int i=1; i<=longestEquals[1]; i++)
            {
                Console.Write($"{longestEquals[0]} ");
            }
            Console.WriteLine();

        }
    }
}
