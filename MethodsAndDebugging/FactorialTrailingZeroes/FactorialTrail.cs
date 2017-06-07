using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrail
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = GetFactorial(n);

            int totalZeros = CountTrailingZeros(factorial);

            Console.WriteLine(totalZeros);
        }

        public static int CountTrailingZeros(BigInteger factorial)
        {
            int count = 0;
            while (true)
            {
                if (factorial % 10 == 0)
                {
                    factorial /= 10;
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public static BigInteger GetFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

    }
}
