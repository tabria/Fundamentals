using System;
using System.Collections.Generic;
using System.Linq;


namespace DragonArmy
{
    class Army
    {
        static void Main()
        {
            int dragonsCount = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<long>>> dragonData = new Dictionary<string, SortedDictionary<string, List<long>>>();
            string[] defaultPowers = new string[] { "45", "250", "10" };

            for (int i=0; i<dragonsCount; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split(' ').ToArray();
                DragonNullPowerReplacer(dragonInfo, defaultPowers);
                FIllDragonData(dragonData, dragonInfo);
            }

            PrintDragonsPowers(dragonData);
        }

        public static void PrintDragonsPowers(Dictionary<string, SortedDictionary<string, List<long>>> dragonData)
        {
            foreach(var kvp in dragonData)
            {
                var averageDamage = kvp.Value.Select(x=>x.Value[0]).Average();
                var averageHealth = kvp.Value.Select(x=>x.Value[1]).Average();
                var averageArmor = kvp.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{kvp.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                
                foreach(var powers in kvp.Value)
                {
                    Console.WriteLine($"-{powers.Key} -> damage: {powers.Value[0]}, health: {powers.Value[1]}, armor: {powers.Value[2]}");
                }
            }
        }

        public static void FIllDragonData(Dictionary<string, SortedDictionary<string, List<long>>> dragonData, string[] dragonInfo)
        {
            var dragonType = dragonInfo[0];
            var dragonName = dragonInfo[1];

            if (!dragonData.ContainsKey(dragonType))
            {
                dragonData[dragonType] = new SortedDictionary<string, List<long>>();
            }

            if (!dragonData[dragonType].ContainsKey(dragonName))
            {
                dragonData[dragonType][dragonName] = new List<long>() { 0, 0, 0};
            }

            for (int i=0; i<3; i++)
            {
                var dragonPower = long.Parse(dragonInfo[i + 2]);

                dragonData[dragonType][dragonName][i] = dragonPower;
            }
        }

        public static void DragonNullPowerReplacer(string[] dragonInfo, string[] defaultPowers)
        {
            for(int i=2; i<dragonInfo.Length; i++)
            {
                if (dragonInfo[i] == "null")
                {
                    dragonInfo[i] = defaultPowers[i - 2];
                }

            }
        }
    }
}
