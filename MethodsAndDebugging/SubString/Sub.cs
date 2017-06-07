using System;

namespace SubString
{
    class Sub
    {
        static void Main()
        {

            string text = Console.ReadLine();
            int countAfterMatchLetters = int.Parse(Console.ReadLine());

            char matchLetter = 'p';
            bool isMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == matchLetter)
                {
                    isMatch = true;

                    int endIndex = countAfterMatchLetters;

                    if (endIndex > text.Length-i-1)
                    {
                        endIndex = text.Length-i-1;
                    }

                    string matchedString = text.Substring(i, endIndex+1);
                    Console.WriteLine(matchedString);
                    i += countAfterMatchLetters;
                }
            }

            if (!isMatch)
            {
                Console.WriteLine("no");
            }

        }
    }
}
