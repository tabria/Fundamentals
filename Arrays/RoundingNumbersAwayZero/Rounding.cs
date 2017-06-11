using System;
using System.Linq;

namespace RoundingNumbersAwayZero
{
    class Rounding
    {
        static void Main()
        {

            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();


            for(int i =0; i<arr.Length; i++)
            {
                //int rounded = (int)(arr[i] + 0.5);
                //Console.WriteLine($"{arr[i]} => {rounded}");
                Console.WriteLine($"{arr[i]} => {Math.Round(arr[i], 0, MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
