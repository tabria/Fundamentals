using System;
using System.Collections.Generic;
using System.Linq;

namespace ImmuneSystem
{
    class Immune
    {
        static void Main()
        {
            int initialImmuneHealth = int.Parse(Console.ReadLine());
            int immuneHealth = initialImmuneHealth;
            Dictionary<string, int> encounteredViruses = new Dictionary<string, int>();

            while (true)
            {
                string virusName = Console.ReadLine();
                if (virusName == "end")
                {
                    Console.WriteLine($"Final Health: {immuneHealth}");
                    break;
                }

                int virusStrength = virusName.Sum(x => x) / 3;
                int timeToDefeatVirus = GetTimeToDefeatVirus(encounteredViruses, virusName, virusStrength);
                
                immuneHealth -= timeToDefeatVirus;
                if (immuneHealth > -1 )
                {
                    int seconds = timeToDefeatVirus % 60;
                    int minutes = timeToDefeatVirus / 60;

                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeatVirus} seconds");
                    Console.WriteLine($"{virusName} defeated in {minutes}m {seconds}s.");
                    Console.WriteLine($"Remaining health: {immuneHealth}");

                    immuneHealth = (int)(immuneHealth * 1.2);
                    immuneHealth = immuneHealth > initialImmuneHealth ? initialImmuneHealth : immuneHealth;
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }

            }

        }

        public static int GetTimeToDefeatVirus(Dictionary<string, int> encounteredViruses, string virusName, int virusStrength)
        {
            int timeToDefeatVirus = 0;
            if (encounteredViruses.ContainsKey(virusName))
            {
                timeToDefeatVirus = encounteredViruses[virusName];
            }
            else
            {
                timeToDefeatVirus = virusStrength * virusName.Length;
                encounteredViruses[virusName] = timeToDefeatVirus / 3;
            }

            return timeToDefeatVirus;
        }
    }
}
