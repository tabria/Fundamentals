using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertBaseNToBase10
{
    class Convert
    {
        static void Main()
        {
            string[] rawInput = Console.ReadLine().Split(' ').ToArray();

            BigInteger baseN = BigInteger.Parse(rawInput[0]);
            char[] baseNNumber = rawInput[1].ToCharArray();

            BigInteger sum = 0;
            int n = 0;
            for(int i=baseNNumber.Length-1; i>=0; i--)
            {
                int num = (int)Char.GetNumericValue(baseNNumber[i]);
                sum += num * BigInteger.Pow(baseN, n);
                n++;
            }
            Console.WriteLine(sum);
        }
    }
}
