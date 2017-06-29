using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class unicode
    {
        static void Main()
        {

            char[] inputStr = Console.ReadLine().ToCharArray();
            string[] convert = inputStr.Select(ch => "\\u" + ((int)ch).ToString("x4")).ToArray();
            Console.WriteLine(string.Join("", convert));

        }
    }
}
