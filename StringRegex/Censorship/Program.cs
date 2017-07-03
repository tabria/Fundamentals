using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Censorship
{
    class Program
    {
        static void Main()
        {

            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            Console.WriteLine(Regex.Replace(sentence, word, new string('*', word.Length)));

        }
    }
}
