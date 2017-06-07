using System;
using System.Collections.Generic;


namespace BePositive
{
    class Positive
    {
        static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] numbers = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                bool isfound = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    int currentNum = int.Parse(numbers[j]);

                    if (currentNum >= 0)
                    {
                        if (isfound)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        isfound = true;
                    }
                    else
                    {
                        if( j+1 > numbers.Length-1)
                        {
                            break;
                        }
                        currentNum += int.Parse(numbers[j + 1]);
                        j++;
                        if (currentNum >= 0)
                        {
                            if (isfound)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            isfound = true;
                        }
                    }
                }
                if (!isfound)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
