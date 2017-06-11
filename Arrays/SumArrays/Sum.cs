using System;
using System.Linq;

namespace SumArrays
{
    class Sum
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxLength = Math.Max(arr1.Length, arr2.Length);
            int[] sum = new int[maxLength];

            for (int i=0; i<sum.Length; i++)
            {
                sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
