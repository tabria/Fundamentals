using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Endurabce
    {
        static void Main()
        {
            string[] playerNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double[] track = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            List<long> checkPoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < playerNames.Length; i++)
            {
                string playerName = playerNames[i];
                double playerFuel = playerName[0];

                for (int k = 0; k < track.Length; k++)
                {
                    if (checkPoints.Contains(k))
                    {
                        playerFuel += track[k];
                    }
                    else
                    {
                        playerFuel -= track[k];
                    }

                    if (playerFuel <= 0)
                    {
                        Console.WriteLine($"{playerName} - reached {k}");
                        break;
                    }
                }

                if (playerFuel > 0)
                {
                    Console.WriteLine($"{playerName} - fuel left {playerFuel:f2}");
                }
            }
        }

    }
}
