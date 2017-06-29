using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace MergeFiles
{
    class Program
    {
        static void Main()
        {

            int[] words1 = File.ReadAllLines("input1.txt").Select(int.Parse).ToArray();
            List<int> words2 = File.ReadAllLines("input2.txt").Select(int.Parse).ToList();
            words2.AddRange(words1);
            Console.WriteLine(string.Join(Environment.NewLine, words2.OrderBy(i => i)));
        }
    }
}
