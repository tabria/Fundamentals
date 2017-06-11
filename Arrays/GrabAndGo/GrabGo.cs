using System;
using System.Linq;

namespace GrabAndGo
{
    class GrabGo
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long number = long.Parse(Console.ReadLine());

            long lastOccuranceIndex = GetLastOccuranceIndex(arr, number);
            if (lastOccuranceIndex < 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(GetSum(arr, lastOccuranceIndex));
            }
            

        }

        public static long GetSum(long[] arr, long lastOccuranceIndex)
        {
            long currentSum = 0;
            for (int i=0; i<lastOccuranceIndex; i++)
            {
                currentSum += arr[i];
            }

            return currentSum;
        }

        public static long GetLastOccuranceIndex(long[] arr, long number)
        {
            long occurancePosition = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    occurancePosition = i;
                }
            }

            return occurancePosition;
        }
    }
}
