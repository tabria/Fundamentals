using System;


namespace SignOfIntegerNumber
{
    public class Sign
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSight(n);

        }

        private static void PrintSight(int n)
        {
            string numberSign = "zero";
            if (n > 0)
            {
                numberSign = "positive";
            }
            else if (n < 0)
            {
                numberSign = "negative";
            }

            Console.WriteLine($"The number {n} is {numberSign}.");

        }
    }
}
