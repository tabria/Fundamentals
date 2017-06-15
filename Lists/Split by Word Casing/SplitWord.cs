using System;
using System.Collections.Generic;
using System.Linq;


namespace Split_by_Word_Casing
{
    class SplitWord
    {
        static void Main()
        {
            List<string> rawWords = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i=0; i<rawWords.Count; i++)
            {
                bool isAllUpper = false;
                bool isAllLower = false;
                for(int k=0; k<rawWords[i].Length; k++)
                {
                    if (char.IsLetter(rawWords[i][k]))
                    {
                        isAllUpper = char.IsUpper(rawWords[i][k]) ? true : isAllUpper;
                        isAllLower = char.IsLower(rawWords[i][k]) ? true : isAllLower;
                    }
                    else
                    {
                        isAllUpper = true;
                        isAllLower = true;
                    }

                    if (isAllUpper && isAllLower)
                    {
                        break;
                    }
                }
                
                if (isAllUpper && !isAllLower)
                {
                    upperCase.Add(rawWords[i]);
                }
                else if (!isAllUpper && isAllLower)
                {
                    lowerCase.Add(rawWords[i]);
                }
                else
                {
                    mixedCase.Add(rawWords[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
