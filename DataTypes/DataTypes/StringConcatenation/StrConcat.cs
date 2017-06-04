using System;

namespace StringConcatenation
{
    class StrConcat
    {
        static void Main()
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int cycles = int.Parse(Console.ReadLine());

            string word = string.Empty;
            for(int i=1; i<=cycles; i++)
            {
                string letter = Console.ReadLine();

                if (evenOdd == "even" && i%2 == 0)
                {
                    word = string.IsNullOrEmpty(word) ? letter : word + delimiter + letter;
                }
                else if (evenOdd == "odd" && i % 2 != 0)
                {
                    word = string.IsNullOrEmpty(word) ? letter : word + delimiter + letter;
                }
            }

            Console.WriteLine(word);

        }
    }
}
