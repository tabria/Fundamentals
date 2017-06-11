using System;
using System.Linq;

namespace JumpAround
{
    class Jump
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int sum = 0;
            while (true)
            {
                int step = arr[startIndex];
                sum += step;

                if (arr.Length-1 >= startIndex + step)
                {
                    startIndex += step;
                }
                else if (startIndex - step >= 0)
                {
                    startIndex -= step;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
