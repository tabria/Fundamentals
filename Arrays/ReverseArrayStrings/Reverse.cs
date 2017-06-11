using System;
using System.Linq;

namespace ReverseArrayStrings
{
    class Reverse
    {
        static void Main()
        {

            string[] arr = Console.ReadLine().Split(' ').ToArray();

            for (int i =0; i<arr.Length/2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
