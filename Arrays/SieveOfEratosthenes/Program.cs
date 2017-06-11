using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {

            int endRange = int.Parse(Console.ReadLine());

            int[] arr = new int[endRange-1];
            int[] incrementInfo = new int[]{ 2, 0 };

            FillArray(arr);
            FindPrimeNumbers(arr, incrementInfo);
            PrintPrimeNumbers(arr);
        }

        public static void PrintPrimeNumbers(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i] != 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();
        }

        public static void FindPrimeNumbers(int[] arr, int[] incrementInfo)
        {
            int increment = incrementInfo[0];
            int startPos = incrementInfo[1] + increment;
            while (increment != 0)
            {
                for (int i = startPos; i < arr.Length; i += increment)
                {
                    if (arr[i] % increment == 0 && arr[i] != 0)
                    {
                        arr[i] = 0;
                    }
                }
                DetermineIncrement(arr, incrementInfo);
                increment = incrementInfo[0];
                startPos = incrementInfo[1] + increment;
            }
        }

        public static void FillArray(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = i + 2;
            }
        }

        public static void DetermineIncrement(int[] arr, int[] incrementInfo)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] != 0 && arr[i]>incrementInfo[0])
                {
                    incrementInfo[0] = arr[i];
                    incrementInfo[1] = i;
                    return;
                }
            }

            incrementInfo[0] = 0;
        }
    }
}
