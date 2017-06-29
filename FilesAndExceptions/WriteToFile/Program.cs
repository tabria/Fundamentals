using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WriteToFile
{
    class Program
    {
        static void Main()
        {
            char[] punctuation = new char[] { '.', ',', '!', '?', ':' , ' '};

            string[] text = File.ReadAllText("input.txt").Split(punctuation, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i=0; i<text.Length; i++)
            {
                if (text[i].Contains("\r") || i == text.Length -1)
                {
                    text[i]=text[i].Remove(0, 1);
                    text[i - 1] += "\"";
                }
            }

            string allWords= string.Join(" ", text).Trim();
            File.WriteAllText("output.txt", allWords);

        }
    }
}
