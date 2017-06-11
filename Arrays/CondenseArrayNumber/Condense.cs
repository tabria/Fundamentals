using System;
using System.Linq;

namespace CondenseArrayNumber
{
    class Condense
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = arr.Length;

            while (count>1)
            {
               
                for (int i = 0; i < count-1; i++)
                {
                    arr[i]= arr[i] + arr[i + 1];
                }
                count--;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
