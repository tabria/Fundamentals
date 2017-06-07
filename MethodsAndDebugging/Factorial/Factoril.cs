using System;
using System.Numerics;

namespace Factorial
{
    class Factoril
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = GetFactorial(n);

            Console.WriteLine(factorial);
        }

        public static BigInteger GetFactorial(int n)
        {
            BigInteger factorial = 1;
            for(int i=1; i<=n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
