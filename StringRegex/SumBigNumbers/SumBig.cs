using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class SumBig
    {
        static void Main()
        {
            char[] numbA = Console.ReadLine().TrimStart('0').ToCharArray();
            char[] numbB = Console.ReadLine().TrimStart('0').ToCharArray();
            StringBuilder sb = new StringBuilder();

            Array.Reverse(numbA);
            Array.Reverse(numbB);

            int extraSum = 0;
            char[] biggerNumber = numbA.Length >= numbB.Length ? numbA : numbB;
            char[] smallestNumber = numbB.Length <= numbA.Length ? numbB : numbA;
            for(int i=0; i<biggerNumber.Length; i++)
            {
                int bigNum = (int)Char.GetNumericValue(biggerNumber[i]);
                int smallNum = 0;
                try
                {
                    smallNum = (int)Char.GetNumericValue(smallestNumber[i]);
                }
                catch { }
               
                var currentSum = bigNum + smallNum + extraSum;
                var currentNumber = currentSum % 10;
                extraSum = currentSum/10;
                sb.Insert(0, currentNumber);
                if (i == biggerNumber.Length - 1 && extraSum != 0)
                {
                    sb.Insert(0,extraSum);
                    break;
                }
            }
           Console.WriteLine(sb.ToString());
           
        }
    }
}
