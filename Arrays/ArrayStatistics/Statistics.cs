using System;
using System.Linq;

namespace ArrayStatistics
{
    class Statistics
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
                max = arr[i] > max ? arr[i] : max;
                min = arr[i] < min ? arr[i] : min;
            }

            double average = sum / (double)arr.Length;
            Console.WriteLine($"Min = {min}" + Environment.NewLine + $"Max = {max}");
            Console.WriteLine($"Sum = {sum}" + Environment.NewLine + $"Average = {average}");

        }
    }
}
