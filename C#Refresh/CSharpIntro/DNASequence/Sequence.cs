using System;

namespace DNASequence
{
    public class Sequence
    {
        public static void Main()
        {
            int matchSum = int.Parse(Console.ReadLine());

            string[] Letters = { "A", "C", "G", "T" };

            for(int i =1; i<=4; i++)
            {
                for (int j=1; j<=4; j++)
                {
                    for (int k=1; k<=4; k++)
                    {
                        string wrap = i + j + k >= matchSum ? "O" : "X";

                        Console.Write($"{wrap}{Letters[i-1]}{Letters[j-1]}{Letters[k-1]}{wrap} ");

                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
