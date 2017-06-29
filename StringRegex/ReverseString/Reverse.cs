using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Reverse
    {
        static void Main()
        {
            char[] textChar = Console.ReadLine().ToCharArray();
            textChar = textChar.Reverse().ToArray();
            Console.WriteLine(new string(textChar));

        }
    }
}
