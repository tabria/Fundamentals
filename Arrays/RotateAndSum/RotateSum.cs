using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateSum
    {
        static void Main()
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];

            while(rotateTimes >= 1)
            {

                RotateArray(arr);
                AddSumArray(arr, sum);
            
                rotateTimes--;
            }

            Console.WriteLine(string.Join(" ", sum));

        }

        public static void RotateArray(int[] arr)
        {
            int temp = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[arr.Length - 1 - i] = arr[arr.Length - 2 - i];

            }
            arr[0] = temp;
        }

        public static void AddSumArray(int[] arr, int[] sum)
        {
            for(int i=0; i<arr.Length; i++)
            {
                sum[i] += arr[i];
            }

        }
    }
}
