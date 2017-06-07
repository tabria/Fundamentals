using System;
using System.Collections.Generic;


namespace PrimesRange
{
    class Range
    {
        static void Main()
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());
            List<int> Primes = new List<int>();


            PutPrimesList(ref Primes, startRange, endRange);

            Console.WriteLine(string.Join(", ", Primes));

        }

        public static void PutPrimesList(ref List<int>PrimeNumbers ,int start, int end)
        {
            for (int k = start; k<= end; k++)
            {
                bool isNumberPrime = isPrime(k);
                if (isNumberPrime)
                {
                    PrimeNumbers.Add(k);
                }
            } 
        }

        public static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
