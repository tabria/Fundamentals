using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BigFactorial
{
    class BigFac
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            BigInteger facNumber = 1;
            for (int i=2; i<=n; i++)
            {
                facNumber *= i;
            }

            Console.WriteLine(facNumber);
        }
    }
}
