using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ByteFlip
{
    class Flip
    {
        static void Main()
        {
            string[] rawDigits = Console.ReadLine().Split(' ')
                                                        .Where(s => s.Length == 2)
                                                        .Select(s=> new string(s.Reverse().ToArray()))
                                                        .Reverse()
                                                        .ToArray();

            char[] final = rawDigits.Select(s => (char)int.Parse(s, NumberStyles.HexNumber)).ToArray();

            Console.WriteLine(string.Join("", final));
        }
    }
}
