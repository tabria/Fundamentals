using System;
using System.Linq;


namespace FoldAndSum
{
    class FoldSum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = arr.Length / 4;

            PrintLeftSum(arr, k);
            PrintRightSum(arr, k);

            Console.WriteLine();

        }

        public static void PrintRightSum(int[] arr, int k)
        {
            int j = arr.Length-1;
            for (int i = arr.Length - 2*k; i < arr.Length - k; i++)
            {
                int sum = arr[i] + arr[j];
                j--;
                Console.Write($"{sum} ");
            }
        }

        public static void PrintLeftSum(int[] arr, int k)
        {
            int j = 1;
            for (int i = k; i < 2 * k; i++)
            {
                int sum = arr[i] + arr[i - j];
                j += 2;
                Console.Write($"{sum} ");
            }
        }
    }
}
