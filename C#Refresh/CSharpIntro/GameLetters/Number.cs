using System;

namespace GameNumbers
{
    public class Number
    {
        public static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinations = 0;
            int firstDigit = 0;
            int lastDigit = 0;

            for(int i=numberN; i<=numberM; i++)
            {
                for(int j=numberN; j<=numberM; j++)
                {
                    combinations++;
  
                    if ( (i + j)== magicNumber)
                    {
                        firstDigit = i;
                        lastDigit = j;
                    }
                }
            }

            if ( (firstDigit + lastDigit) == magicNumber)
            {
                Console.WriteLine($"Number found! {firstDigit} + {lastDigit} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
