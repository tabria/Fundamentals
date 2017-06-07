using System;


namespace PrintingTriangle
{
    public class Triangle
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            PrintingTriangle(n);

        }

        private static void PrintingTriangle(int n)
        {
            PrintUpperPart(n);
            PrintLowerPart(n);
        }

        private static void PrintLowerPart(int n)
        {
            for (int k = n-1; k >0; k--)
            {
                PrintLine(k);
            }
        }

        private static void PrintUpperPart(int n)
        {
            for (int k = 1; k<=n; k++)
            {
                PrintLine(k);
            }
        }

        public static void PrintLine(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

    }
}
