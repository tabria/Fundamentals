using System;

namespace TestNumbers
{
    public class TestNum
    {
        public static void Main()
        {
            int numberN = int.Parse(Console.ReadLine());
            int numberM = int.Parse(Console.ReadLine());
            int maxBoundary = int.Parse(Console.ReadLine());

            int sum = 0;
            int combinations = 0;
            for(int i=numberN; i>=1; i--)
            {
                for (int j=1; j<=numberM; j++)
                {
                    int currentNumber = (i * j) * 3;
                    sum += currentNumber;
                    combinations++;
                    if (sum >= maxBoundary)
                    {
                        goto UnderMainLoop;
                    }
                }
            }
        UnderMainLoop:

            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine(sum >= maxBoundary ? $"Sum: {sum} >= {maxBoundary}" : $"Sum: {sum}");
        }
    }
}
