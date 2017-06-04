using System;

namespace SentenceThief
{
    class Sentence
    {
        static void Main()
        {
            string idType = Console.ReadLine();
            int cycles = int.Parse(Console.ReadLine());

            long thiefID = long.MinValue;
            for (int i = 0; i < cycles; i++)
            {

                if (idType == "sbyte")
                {
                    try
                    {
                        sbyte currentId = sbyte.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }
                else if (idType == "int")
                {
                    try
                    {
                        int currentId = int.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }
                else if (idType == "long")
                {
                    try
                    {
                        long currentId = long.Parse(Console.ReadLine());
                        thiefID = thiefID < currentId ? currentId : thiefID;
                    }
                    catch { }
                }

            }
            long sentence = 0;
            if (thiefID >= 0)
            {
                sentence = (long)Math.Ceiling(thiefID / (double)sbyte.MaxValue);
            }
            else
            {
                sentence = (long)Math.Ceiling(thiefID / (double)sbyte.MinValue);
            }
            string years = sentence == 1 ? "year" : "years";
            Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} {years}");
        }
    }
}
