using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            string[] word = File.ReadAllText("exercise.txt").ToLower().Split();
            string[] inputWords = File.ReadAllText("input.txt").ToLower()
                                        .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countWords = word.ToDictionary(key=>key, value=>0 );
            for (int i=0; i<inputWords.Length; i++)
            {
                string searchWord = inputWords[i];
                if (countWords.ContainsKey(searchWord))
                {
                    countWords[searchWord] += 1;
                }
            }

            string text = string.Join("", countWords.OrderByDescending(i=>i.Value).Select(s => s.Key + " - " + s.Value + Environment.NewLine));
            File.AppendAllText("Output.txt", text);
        }
    }
}
