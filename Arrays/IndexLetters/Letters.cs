using System;
using System.Linq;

namespace IndexLetters
{
    class Letters
    {
        static void Main()
        {
            char[] letters = new char['z' - 'a' + 1];

            FillLettersArray(letters);

            string word = Console.ReadLine();

            PrintLettersIndex(letters, word);

        }

        public static void PrintLettersIndex(char[] letters, string word)
        {
           for (int i = 0; i<word.Length; i++)
            {
                for (int k=0; k<letters.Length; k++)
                {
                    if (word[i] == letters[k])
                    {
                        Console.WriteLine($"{word[i]} -> {k}");
                    }
                }
            }
        }

        public static void FillLettersArray (char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)('a' + i);
            }
        }
    }
}
