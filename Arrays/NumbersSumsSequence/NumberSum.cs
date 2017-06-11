using System;

namespace NumbersSumsSequence
{
    class NumberSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];

            arr[0] = 1;
            for (int i=1;i<=arr.Length-1; i++)
            {
                long sum = 0;
                int start = i > k? i-k : 0 ;
                for (int j =start; j<i; j++)
                {
                    sum+=arr[j];
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}
