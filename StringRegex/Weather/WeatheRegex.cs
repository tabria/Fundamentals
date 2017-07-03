using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class WeatheRegex
    {
        static void Main(string[] args)
        {
            Dictionary<string, Match> realWeather = new Dictionary<string, Match>();
            while (true)
            {
                string currentWeather = Console.ReadLine();
                if (currentWeather == "end")
                {
                    break;
                }
                string regex = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-z]+)\|";
                Match weatherInfo = Regex.Match(currentWeather, regex);
                if (weatherInfo.Length > 0)
                {
                    string town = weatherInfo.Groups["city"].Value;
                    realWeather[town] = weatherInfo;
                }

            }

            var results = realWeather.OrderBy(s => s.Value.Groups["temp"].Value).Select(s => $"{s.Value.Groups["city"]} => {s.Value.Groups["temp"]:f2} => {s.Value.Groups["weather"]}").ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}
