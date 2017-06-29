using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CharacterMultiplier
{
    class Multiplier
    {
        static void Main()
        {
            string[] inputStr = Console.ReadLine().Split(' ').ToArray();

            string strA = inputStr[0];
            string strB = inputStr[1];
            Console.WriteLine(CalcMultiplier(strA, strB));
        }

         static BigInteger CalcMultiplier(string strA, string strB)
        {
            int smallestLength = strA.Length < strB.Length ? strA.Length : strB.Length;
            BigInteger sum = 0;
            for (int i=0; i< smallestLength; i++)
            {
                int a = strA[i];
                int b = strB[i];
                sum += strA[i] * strB[i];
            }
            return sum += AddExtraCharsSum(strA, strB);
        }

        public static BigInteger AddExtraCharsSum(string strA, string strB)
        {
            int result = strA.Length - strB.Length;
            if ( result == 0)
            {
                return 0;
            }
           else if(result > 0)
            {
                return SumExtraChars(result, strA);
            }
           else
            {
                return SumExtraChars(Math.Abs(result), strB);
            }

        }

        static BigInteger SumExtraChars(int result, string strBase)
        {
            BigInteger sum = 0;
            for(int i=result; i>0; i--)
            {
                sum += strBase[strBase.Length-i];
            }
            return sum;
        }
    }
}
