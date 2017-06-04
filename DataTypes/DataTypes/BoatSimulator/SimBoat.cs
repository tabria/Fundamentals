using System;

namespace BoatSimulator
{
    class SimBoat
    {
        static void Main()
        {
            char boatOne = char.Parse(Console.ReadLine());
            char boatTwo = char.Parse(Console.ReadLine());
            int cycles = int.Parse(Console.ReadLine());

            int firstBoatMoves = 0;
            int secondBoatMoves = 0;
            for(int i=1; i<=cycles; i++)
            {
                if (firstBoatMoves >= 50)
                {
                    break;
                }
                else if (secondBoatMoves >=50)
                {
                    break;
                }

                string randomWords = Console.ReadLine();

                if(randomWords == "UPGRADE")
                {
                    boatOne = (char)(boatOne + 3);
                    boatTwo = (char)(boatTwo + 3);
                    continue;
                }

                if (i%2 == 0)
                {
                    secondBoatMoves += randomWords.Length;
                }
                else
                {
                    firstBoatMoves += randomWords.Length;
                }
            }

            if (firstBoatMoves > secondBoatMoves)
            {
                Console.WriteLine(boatOne);
            }
            else
            {
                Console.WriteLine(boatTwo);
            }


        }
    }
}
