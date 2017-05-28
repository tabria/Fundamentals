using System;

namespace MagicLetter
{
   public class Letter
    {
        public static void Main()
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());


            for(char i=firstLetter; i<=secondLetter; i++)
            {
                if (i == thirdLetter)
                {
                    continue;
                } 
                else
                {
                    for (char j=firstLetter; j<=secondLetter; j++)
                    {
                        if (j == thirdLetter)
                        {
                            continue;
                        } 
                        else
                        {
                            for (char k=firstLetter; k<=secondLetter; k++)
                            {
                                if (k == thirdLetter)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.Write($"{i}{j}{k} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
