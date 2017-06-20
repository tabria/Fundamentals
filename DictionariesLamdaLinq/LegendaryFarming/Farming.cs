using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Farming
    {
        static void Main()
        {
            SortedDictionary<string, int> crapMaterials = new SortedDictionary<string, int>();
            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int> { { "shards", 0}, {"fragments", 0 }, {"motes", 0 } };
            Dictionary<string, string> legendaryItems = new Dictionary<string, string> { { "shards", "Shadowmourne" }, { "fragments", "Valanyr" }, { "motes", "Dragonwrath" } };

            bool isLegendary = false;
            string legendaryItem = string.Empty;
            while (!isLegendary)
            {
                string[] currentMaterial = Console.ReadLine().ToLower().Split(' ');

                for (int i=1;i < currentMaterial.Length; i+=2)
                {
                    bool isCrap = (currentMaterial[i] == "shards" || currentMaterial[i] == "fragments" || currentMaterial[i] == "motes") ? false : true;

                    if (!isCrap)
                    {
                        legendaryMaterials[currentMaterial[i]] += int.Parse(currentMaterial[i - 1]);

                        if (legendaryMaterials[currentMaterial[i]] >= 250)
                        {
                            legendaryItem = legendaryItems[currentMaterial[i]];
                            legendaryMaterials[currentMaterial[i]] -= 250;
                            isLegendary = true;
                            break;
                        }
                    }
                    else if (isCrap && !crapMaterials.ContainsKey(currentMaterial[i]))
                    {
                        crapMaterials[currentMaterial[i]] = int.Parse(currentMaterial[i - 1]);
                    }
                    else
                    {
                        crapMaterials[currentMaterial[i]] += int.Parse(currentMaterial[i - 1]);
                    }
                }

            }

            Console.WriteLine($"{legendaryItem} obtained!");
            var legendaryMaterialsLeft = legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x=>x.Key);
            Console.Write(string.Join("",legendaryMaterialsLeft.Select(x=>x.Key + ": " + x.Value + Environment.NewLine)));
            Console.Write(string.Join("",crapMaterials.Select(x=>x.Key +": " + x.Value + Environment.NewLine)));

        }
    }
}
