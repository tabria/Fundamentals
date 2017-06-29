using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace PunctuationFinder
{
    class Finder
    {
        static void Main()
        {
            char[] punctuation = new char[] {'.', ',', '!', '?', ':'};

            string[] text = File.ReadAllText("input.txt").Split(new char[] { ' ', '\r', '\n', '\"'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //Console.WriteLine(PunctuationFound(text, punctuation));
            File.WriteAllText("output.txt", PunctuationFound(text, punctuation));
        }

        public static string PunctuationFound(string[] text, char[] punctuation)
        {
            string foundPunctuation = string.Empty;
            foreach (var word in text)
            {
                foreach (var sign in punctuation)
                {
                    string separator = foundPunctuation.Length == 0 ? string.Empty : ", ";
                    if (word[word.Length - 1] == sign)
                    {
                        foundPunctuation += separator + sign;
                        break;
                    }
                }
            }
            return foundPunctuation;
        }
    }
}
