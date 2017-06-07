using System;

namespace MultiplyEvensByOdds
{
    class multiply
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResultMultiplyingOddEven(Math.Abs(number)));


        }

        public static int GetResultMultiplyingOddEven(int number)
        {
            int sumOdd = GetOddNumbersSum(number);
            int sumEven = GetEvenNumbersSum(number);

            return sumOdd * sumEven;
        }

        public static int GetEvenNumbersSum(int number)
        {
            int sumEven = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentDigit;
                }
            }

            return sumEven;
        }

        public static int GetOddNumbersSum(int number)
        {
            int sumOdd = 0;
            while(number>0)
            {
                int currentDigit = number % 10;
                number /= 10;
                if (currentDigit % 2 != 0)
                {
                    sumOdd += currentDigit;
                }
            }

            return sumOdd;
        }
    }
}
