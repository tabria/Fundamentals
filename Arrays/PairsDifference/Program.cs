using System;
using System.Linq;

namespace PairsDifference
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int controlNumber = int.Parse(Console.ReadLine());
            int countPairs = 0;
            for (int i=0; i<arr.Length; i++)
            {
                for(int k=i+1; k<arr.Length; k++)
                {
                    int currentDifference = Math.Abs(arr[i] - arr[k]);

                    if (controlNumber == currentDifference)
                    {
                        countPairs++;
                    }
                }
                
            }

            Console.WriteLine(countPairs);
        }
    }
}
