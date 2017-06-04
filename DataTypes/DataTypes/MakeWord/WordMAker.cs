using System;


namespace MakeWord
{
    class WordMAker
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());

            string word = string.Empty;
            for (int i=0; i<cycles; i++)
            {

                string letter = Console.ReadLine();
                word += letter;

            }
            Console.WriteLine($"The word is: {word}");

        }
    }
}
