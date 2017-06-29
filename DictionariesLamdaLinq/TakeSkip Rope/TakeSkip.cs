using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkip_Rope
{
    class TakeSkip
    {
        static void Main()
        {

            string word = Console.ReadLine();
            char[] onlyLetters = word.Where(ch => ch<48 || ch>57).ToArray();
            int[] onlyDigits = word.Where(ch => char.IsDigit(ch)).Select(ch => int.Parse(ch.ToString())).ToArray();
            int[] takeList = onlyDigits.Where((i, index) => index % 2 ==0).ToArray();
            int[] skipList = onlyDigits.Where((i, index) => index % 2 != 0).ToArray();

            List<string> decodedString = new List<string>();

            int total = 0;
            var takenStr = string.Empty;
            for (int i=0; i<skipList.Length; i++)
            {
                int takeChars = takeList[i];
                takenStr += string.Join("",onlyLetters.Skip(total).Take(takeChars).ToArray());
                total += skipList[i] + takeChars;
            }

            Console.WriteLine(takenStr);
        }
    }
}
