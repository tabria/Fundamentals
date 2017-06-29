using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Change
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal totalSum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                totalSum += ExtractWordValue(words[i]);
            }

            Console.WriteLine("{0:f2}", totalSum);
        }

        public static decimal ExtractWordValue(string rawWord)
        {
            char firstLetter = rawWord[0];
            char lastLetter = rawWord[rawWord.Length - 1];

            char[] extractedNumbers = rawWord.Where(char.IsDigit).ToArray();
            var number = long.Parse(new string(extractedNumbers));

            decimal result = 0;
            decimal position = GetLetterPosition(firstLetter);
            result = char.IsUpper(firstLetter) ? number / position : number * position;

            position = GetLetterPosition(lastLetter);
            result = char.IsUpper(lastLetter) ? result - position : result + position;

            return result;
        }

        static decimal GetLetterPosition(char letter)
        {
            if (char.IsUpper(letter))
            {
                return letter - 'A' + 1;
            }
            return letter - 'a' + 1;
        }
    }
}
