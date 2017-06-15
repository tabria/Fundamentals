using System;
using System.Collections.Generic;
using System.Linq;


namespace SumReversedNumbers
{
    class ReverseSum
    {
        static void Main()
        {

            List<int> digits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i=0; i<digits.Count; i++)
            {
                string currentNum = digits[i].ToString();
                char[] reversedNum = currentNum.Reverse().ToArray();
                string reversed = new string(reversedNum);

                digits[i] = int.Parse(reversed);
            }
            Console.WriteLine(digits.Sum());
        }
    }
}
