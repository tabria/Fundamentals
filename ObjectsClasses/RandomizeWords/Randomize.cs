using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Randomize
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for(int i =0; i<words.Length; i++)
            {
                var temp = words[i];
                var randPos = rnd.Next(words.Length);
                words[i] = words[randPos];
                words[randPos] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine,words));

        }
    }
}
