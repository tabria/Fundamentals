using System;

namespace NumbersReversedOrder
{
    public class NumberReversed
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            Console.WriteLine(ReversingNumber(number));

        }

        public static string ReversingNumber(string number)
        {
            string numberReverse = string.Empty;
            for (int i = 1; i <= number.Length; i++)
            {
                numberReverse += number[number.Length - i];
            }

            return numberReverse;
        }

    }
}
