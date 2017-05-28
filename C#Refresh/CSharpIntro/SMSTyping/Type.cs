using System;

namespace SMSTyping
{
    public class Type
    {
        public static void Main()
        {
            int numChar = int.Parse(Console.ReadLine());


            string message = string.Empty;
            for (int i=1; i<=numChar; i++)
            {
                int intLetter = int.Parse(Console.ReadLine());

                if (intLetter == 0)
                {
                    message += " ";
                    continue;
                }
              
                int countNumbers = 0;
                while (true)
                {
                    if (intLetter / 10 == 0)
                    {
                        int previouseLetter = intLetter <= 2 ? 1 : intLetter - 1;
                        int offset = intLetter >= 8 ? 1 : 0;
                        message += (char)(95 + intLetter + (previouseLetter - 1) * 2 + offset + countNumbers);
                        break;
                    }  

                    intLetter /= 10;
                    countNumbers++;
                }
            }
            Console.WriteLine(message);
        }
    }
}
