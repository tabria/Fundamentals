using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {

            int[] text = File.ReadAllText("exercise.txt").Split(' ').Select(int.Parse).ToArray();

            int currentNumber = 0;
            int currentCount = 0;
            for (int i=0; i<text.Length; i++)
            {
                int count = 0;
                for (int k=i; k<text.Length; k++)
                {
                    if (text[i] == text[k])
                    {
                        count++;
                    }
                }
            
                if (currentCount < count)
                {
                    currentCount = count;
                    currentNumber = text[i];
                }
            }

            File.WriteAllText("output.txt", currentNumber.ToString());
        }
    }
}
