using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class Middle
    {
        static void Main()
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            if (arr.Length == 1)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                int elementOne = arr[(arr.Length / 2) - 1];
                int elementTwo = arr[arr.Length / 2];
                Console.WriteLine($"{{ {elementOne}, {elementTwo}  }}");
            }
            else if (arr.Length % 2 != 0)
            {
                int elementOne = arr[(arr.Length / 2) - 1];
                int elementTwo = arr[arr.Length / 2];
                int elementThree = arr[(arr.Length / 2) + 1];
                Console.WriteLine($"{{ {elementOne}, {elementTwo}, {elementThree}  }}");
            }

        }

    }
}
