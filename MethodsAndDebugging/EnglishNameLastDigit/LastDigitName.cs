using System;


namespace EnglishNameLastDigit
{
   public class LastDigitName
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetLastDigitName(number));

        }

        private static string GetLastDigitName(long number)
        {
            long lastDigit = Math.Abs(number) % 10;
            string message = string.Empty;

            switch (lastDigit)
            {
                case 0: message = "zero"; break;
                case 1: message = "one"; break;
                case 2: message = "two"; break;
                case 3: message = "three"; break;
                case 4: message = "four"; break;
                case 5: message = "five"; break;
                case 6: message = "six"; break;
                case 7: message = "seven"; break;
                case 8: message = "eight"; break;
                case 9: message = "nine"; break;
                default: break;
            }
            return message;
        }
    }
}
