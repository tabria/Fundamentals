using System;
using System.Collections.Generic;
using System.Linq;

namespace SerbianUnleashed
{
    class Chalga
    {
        static void Main()
        {

            Dictionary<string, Dictionary<string, int>> concertInfo = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string rawConcertInfo = Console.ReadLine();
                if (rawConcertInfo == "End")
                {
                    break;
                }

                int atIndex = rawConcertInfo.IndexOf('@');
                if (rawConcertInfo[atIndex - 1] != ' ')
                {
                    continue;
                }

                string[] atSplit = rawConcertInfo.Split('@').ToArray();
                var singerName = atSplit[0].Trim();
                string[] concertArr = atSplit[1].Split(' ').ToArray();

                int tickets = 0;
                int ticketPrice = 0;
                try
                {
                    tickets = int.Parse(concertArr[concertArr.Length - 1]);
                    ticketPrice = int.Parse(concertArr[concertArr.Length - 2]);
                }
                catch
                {
                    continue;
                }

                string concertLocation = GetLocation(concertArr);
                int profit = tickets * ticketPrice;

                FillConcertInfo(concertInfo, concertLocation, profit, singerName); 
            }

            PrintConcertInfo(concertInfo);
        }

        public static void PrintConcertInfo(Dictionary<string, Dictionary<string, int>> concertInfo)
        {
            foreach (var placeSinger in concertInfo)
            {
                Console.WriteLine($"{placeSinger.Key}");
                foreach (var singerProfit in placeSinger.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerProfit.Key} -> {singerProfit.Value}");
                }
            }
        }

        private static void FillConcertInfo(Dictionary<string, Dictionary<string, int>> concertInfo, string concertLocation, int profit, string singerName)
        {
            if (!concertInfo.ContainsKey(concertLocation))
            {
                concertInfo[concertLocation] = new Dictionary<string, int>();
            }

            if (!concertInfo[concertLocation].ContainsKey(singerName))
            {
                concertInfo[concertLocation][singerName] = profit;
            }
            else
            {
                concertInfo[concertLocation][singerName] += profit;
            }
        }

        public static string GetLocation(string[] concertArr)
        {
            string location = string.Empty;
            for (int i = 0; i < concertArr.Length - 2; i++)
            {
                string space = i == concertArr.Length - 3 ? string.Empty : " ";
                location += concertArr[i] + space;
            }

            return location;
        }
    }
}
