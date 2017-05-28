using System;

namespace TriangleOfNumbers
{
    public class Triangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int k=0; k<i; k++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }


        }
    }
}
