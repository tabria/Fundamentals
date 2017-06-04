using System;


namespace SumChars
{
    class CharSum
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());

            int sum = 0;
            for(int i=0; i<cycles; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                sum+= currentChar;

            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
