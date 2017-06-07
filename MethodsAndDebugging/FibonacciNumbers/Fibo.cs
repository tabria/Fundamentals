using System;

namespace FibonacciNumbers
{
    static class Fibo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(n));

        }

        private static int Fib(int n)
        {
            int fiboNumber = 1;
            int seedOne = 0;
            int seedTwo = 1;
            for (int i=0; i <=n; i++)
            {
                fiboNumber = seedOne + seedTwo;
                seedTwo = seedOne;
                seedOne = fiboNumber;
            }

            return fiboNumber;
        }
    }
}
