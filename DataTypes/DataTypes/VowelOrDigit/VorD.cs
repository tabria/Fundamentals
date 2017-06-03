using System;

namespace VowelOrDigit
{
    class VorD
    {
        static void Main()
        {

            char symbol = char.Parse(Console.ReadLine());

            string message = "other";
            if (symbol >= 48 && symbol <= 57)
            {
                message = "digit";
            }
            else if (symbol == 65 || symbol == 97 || symbol == 69 || symbol == 101 || symbol == 73 || symbol == 105 || symbol == 79 || symbol == 111 || symbol == 85 || symbol == 117)
            {
                message = "vowel";
            }

            Console.WriteLine(message);

        }
    }
}
