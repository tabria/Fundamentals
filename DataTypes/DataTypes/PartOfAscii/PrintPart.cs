using System;


namespace PartOfAscii
{
    class PrintPart
    {
        static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for(char i = (char)startChar; i<=(char)endChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
