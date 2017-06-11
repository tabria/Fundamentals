using System;

namespace ReverseArrayIntegers
{
    class ReverseArray
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());

            int[] arr = new int[cycles];

            FillArray(arr, cycles);
            ArrayReverse(arr);

            Console.WriteLine(string.Join(" ", arr));

        }

        public static void ArrayReverse(int[] arrayToReverse)
        {
            
            for (int i=0; i< arrayToReverse.Length/2; i++)
            {
                int temp = arrayToReverse[i];
                arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - 1 - i];
                arrayToReverse[arrayToReverse.Length - 1-i] = temp;
            }
            

        }

        public static void FillArray(int[] arrayToFill, int count)
        {
            for (int i = 0; i < count; i++)
            {
                arrayToFill[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
