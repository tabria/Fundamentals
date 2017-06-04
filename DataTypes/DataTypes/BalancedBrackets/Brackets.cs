using System;

namespace BalancedBrackets
{
    class Brackets
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());

            string balance = string.Empty;
            char prevChar = '\0';
            char currentChar = '\0';
            for (int i=0; i<cycles; i++)
            {
                string currentString = Console.ReadLine();
                string randomString = string.Empty;


                try
                {
                    char thisChar = char.Parse(currentString);
                    if (thisChar ==')' || thisChar == '(')
                    {
                        currentChar = thisChar;
                    }
                    else
                    {
                        randomString = currentString;
                    }

                }
                catch
                {
                    randomString = currentString;
                }

                if (!string.IsNullOrEmpty(randomString))
                {
                    continue;
                }

                if (prevChar == '\0' && string.IsNullOrEmpty(randomString))
                {
                    prevChar = currentChar;
                    currentChar = '\0';
                    continue;
                }
                if (balance == "UNBALANCED")
                {
                    continue;
                }

                if (prevChar == '(' && currentChar == ')')
                {
                    balance = "BALANCED";
                    prevChar = '\0';
                    currentChar = '\0';
                }
                else
                {
                    balance = "UNBALANCED";
                }
            }
            if (prevChar !='\0' && currentChar == '\0')
            {
                balance = "UNBALANCED";
            }
            Console.WriteLine(balance);

        }
    }
}
