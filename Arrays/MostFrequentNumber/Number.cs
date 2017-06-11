using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Number
    {
        static void Main()
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] numbers = new int[arr.Length];
            int[] occurance = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                bool isFound = false;

                CountOccurance(numbers, occurance, arr[i], ref isFound);

                if (!isFound)
                {
                    AddNumbers(numbers, occurance, arr[i]);
                }
            }

            PrintNumber(numbers, occurance);
        }

        public static void PrintNumber(int[] numbers, int[] occurance)
        {
            int numberToPrint = numbers[0];
            int currentOccurance = occurance[0];

            for (int i=1; i<occurance.Length; i++)
            {
                if (occurance[i] == 0)
                {
                    break;
                }
                numberToPrint = currentOccurance < occurance[i] ? numbers[i] : numberToPrint;
            }

            Console.WriteLine(numberToPrint);
        }

        public static void CountOccurance(int[] numbers, int[] occurance, int numberToSearch, ref bool isFound)
        {
            for (int k = 0; k < numbers.Length; k++)
            {
                if (numberToSearch == numbers[k])
                {
                    occurance[k] += 1;
                    isFound = true;
                    break;
                }
            }
        }

        public static void AddNumbers(int[] numbers, int[] occurance, int numberToSearch)
        {
            for (int k = 0; k < occurance.Length; k++)
            {
                if (occurance[k] == 0)
                {
                    numbers[k] = numberToSearch;
                    occurance[k] = 1;
                    break;
                }
            }
        }
    }
}
