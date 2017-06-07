using System;

namespace PrimeChecker
{
    class PrimeCheck
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            bool prime = isPrime(n);
            Console.WriteLine(prime);

        }

        public static bool isPrime(long n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n <2)
            {
                return false;
            }
            for (long i=2; i<= Math.Ceiling(Math.Sqrt(n)); i++)
            {

                if (n % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
