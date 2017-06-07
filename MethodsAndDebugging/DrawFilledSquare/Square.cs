using System;

namespace DrawFilledSquare
{
    public class Square
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSquare(n);

        }

        private static void PrintSquare(int n)
        {
            PrintUpperLowerBorder('-', 2 * n);
            PrintBody('-', "\\/", n);
            PrintUpperLowerBorder('-', 2 * n);

        }

        private static void PrintBody(char wrap, string text, int cycles)
        {
            for (int k=1; k<=cycles-2; k++)
            {
                Console.Write(wrap);
                for(int i =0; i <= cycles - 2; i++)
                {
                    Console.Write(text);
                }
                Console.WriteLine(wrap);
            }
            
        }

        private static void PrintUpperLowerBorder(char lineFiller, int length)
        {
            Console.WriteLine(new String(lineFiller, length));
        }
    }
}
