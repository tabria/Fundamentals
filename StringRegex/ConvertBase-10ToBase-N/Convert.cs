using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertBase_10ToBase_N
{
    class Convert
    {
        static void Main()
        {

            BigInteger[] rawInput = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger baseN = rawInput[0];
            BigInteger base10Number = rawInput[1];

            StringBuilder sb = new StringBuilder();

            while (base10Number > 0)
            {
                sb.Insert( 0, base10Number % baseN);
                base10Number = base10Number / baseN;
            }

            Console.WriteLine(sb);
        }
    }
}
