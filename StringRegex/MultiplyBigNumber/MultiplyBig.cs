using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class MultiplyBig
    {
        static void Main()
        {
            char[] numbA = Console.ReadLine().TrimStart('0').ToCharArray();
            char[] numbB = Console.ReadLine().TrimStart('0').ToCharArray();
            List<int> result = new List<int>();

            Array.Reverse(numbA);
            Array.Reverse(numbB);

            char[] biggerNumber = numbA.Length >= numbB.Length ? numbA : numbB;
            char[] smallestNumber = numbB.Length <= numbA.Length ? numbB : numbA;
            for (int i = 0; i < smallestNumber.Length; i++)
            {
                int smallNum = (int)Char.GetNumericValue(smallestNumber[i]);

                var subResult = MultiplyByNumberresult(biggerNumber, smallNum, i);

                if (result.Count == 0)
                {
                    result = subResult;
                }
                else
                {
                    result = SumMultiplicationResults(subResult, result);
                }


            }
            if (result.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                result.Reverse();
                Console.WriteLine(string.Join("", result));
            }
        }

        public static List<int> SumMultiplicationResults(List<int> subResult, List<int> result)
        {
            int extraSumResult = 0;
            for (int j = 0; j < subResult.Count; j++)
            {
                int subResultNum = subResult[j];
                int resultNum = 0;
                try
                {
                    resultNum = result[j];
                }
                catch { }

                var currentSum = subResultNum + resultNum + extraSumResult;
                var currentNumber = currentSum % 10;
                extraSumResult = currentSum / 10;
                result.Add(currentNumber);
                if (j == subResult.Count - 1 && extraSumResult != 0)
                {
                    result.Add(extraSumResult);
                    break;
                }
            }
            return result;
        }

        public static List<int> MultiplyByNumberresult(char[] biggerNumber, int smallNum, int addZeroIndex)
        {
            List<int> subResult = new List<int>();
            int extraSum = 0;
            for (int k = 0; k < biggerNumber.Length; k++)
            {
                for (int j = addZeroIndex; j > 0; j--)
                {
                    subResult.Add(0);
                }

                int bigNum = (int)Char.GetNumericValue(biggerNumber[k]);
                var currentMultiplication = bigNum * smallNum + extraSum;
                var currentNumber = currentMultiplication % 10;
                extraSum = currentMultiplication / 10;
                subResult.Add(currentNumber);
                if (k == biggerNumber.Length - 1 && extraSum != 0)
                {
                    subResult.Add(extraSum);
                    break;
                }

            }

            return subResult;
        }
    }
}
