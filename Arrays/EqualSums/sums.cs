using System;
using System.Linq;

namespace EqualSums
{
    class Sums
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Console.WriteLine(GetFinalResult(arr));
        }

        public static string GetFinalResult(long[] arr)
        {
            string output = "no";
            long leftSum = 0;
            long rightSum = GetRightSum(arr);

            for (int i = 0; i < arr.Length; i++)
            {       
                if (leftSum == rightSum)
                {
                    output = i.ToString();
                    break;
                }
                rightSum = rightSum == 0 ? 0 : rightSum - arr[i+1];
                leftSum += arr[i];
            }

            return output;
        }

        public static long GetRightSum(long[] arr)
        {
            long sum = 0;
            for(int i=arr.Length-1; i>0; i--)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
