using System;

namespace DecryptingMessage
{
    class Decrypt
    {
        static void Main()
        {

            int key = int.Parse(Console.ReadLine());
            int cycles = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for(int i=0; i<cycles; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                message += (char)(currentChar + key);

            }
            Console.WriteLine(message);
        }
    }
}
