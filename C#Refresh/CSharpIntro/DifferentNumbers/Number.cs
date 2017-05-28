using System;

namespace DifferentNumbers
{
    public class Number
    {
        public static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            if ((numberB - numberA) < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i=numberA; i<=numberB - 4; i++)
            {
                for (int j=i+1; j<=numberB - 3; j++)
                {
                    for (int k=j+1; k<=numberB - 2; k++)
                    {
                        for (int m=k+1; m<=numberB - 1; m++)
                        {
                            for (int n=m+1; n<=numberB; n++)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {n}");
                            }
                        }
                    }
                }
            }

        }
    }
}
