using System;

namespace RefactorSpecialNumbers
{
    class SNumbers2
    {
        static void Main()
        {

            int numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers; i++)

            {

                int currentNumber = i;
                int sum = 0;
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
