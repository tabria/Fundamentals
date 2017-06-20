using System;
using System.Collections.Generic;
using System.Linq;


namespace PopulationCounter
{
    class Counter
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> country = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] countryInfo = Console.ReadLine().Split('|').ToArray();

                string city = countryInfo[0];
                if (city == "report")
                {
                    break;
                }
                string state = countryInfo[1];
                long population = long.Parse(countryInfo[2]);

                if (!country.ContainsKey(state))
                {
                    country[state] = new Dictionary<string, long>();
                }
                country[state][city] = population;
                country[state] = country[state].OrderByDescending(town => town.Value).ToDictionary(town=>town.Key, town=>town.Value);
              
            }
            country = country.OrderByDescending(x => x.Value.Sum(v => v.Value)).ToDictionary(x => x.Key, x=> x.Value);

            foreach( var kvp in country)
            {
                long sum = 0;
                string output = string.Empty;
                foreach(var cityPair in kvp.Value)
                {
                    sum += cityPair.Value;
                    string newLine = cityPair.Equals(kvp.Value.Last()) ? "" : Environment.NewLine;
                    output += $"=>{cityPair.Key}: {cityPair.Value}{newLine}";
                }
                Console.WriteLine($"{kvp.Key} (total population: {sum}){Environment.NewLine}{output}");
            }
        }
    }
}
