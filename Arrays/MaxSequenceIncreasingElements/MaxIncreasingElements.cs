using System;
using System.Linq;


namespace MaxSequenceIncreasingElements
{
    class MaxIncreasingElements
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isSequence = false;
            int[] longestEquals = new int[3];
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    count = isSequence == false ? count + 2: count + 1;
                    isSequence = true;
                    if (i == arr.Length - 1)
                    {
                        InsertEqualsInfo(longestEquals, i+1, count);
                    }
                }
                else if (arr[i] <= arr[i - 1] && isSequence == true)
                {
                    isSequence = false;
                    InsertEqualsInfo(longestEquals, i, count);
                    count = 0;
                }
            }

            if (longestEquals[2] == 0)
            {
                longestEquals[2] = count;
                longestEquals[1] = count;
                longestEquals[0] = 0;
            }

            for (int i = longestEquals[0]; i <=longestEquals[1]; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

        }

        public static void InsertEqualsInfo(int[] longestEquals, int i, int count)
        {
            if (longestEquals[2] < count)
            {
                longestEquals[2] = count;
                longestEquals[1] = i - 1;
                longestEquals[0] = i - count;
            }
        }
    }
}
