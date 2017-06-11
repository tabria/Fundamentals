using System;
using System.Linq;


namespace TripleSum
{
    class Sum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isExist = false;
            for(int i = 0; i<arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] == sum)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                            isExist = true;
                            break;
                        }
                    }
                }
            }
            if (!isExist)
            {
                Console.WriteLine("No");
            }

        }
    }
}
