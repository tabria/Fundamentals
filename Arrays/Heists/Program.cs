using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main()
        {
            int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long profit = 0;
            while (true)
            {
                string[] loot = Console.ReadLine().Split(' ').ToArray();
                
                if (loot[0] == "Jail" && loot[1] == "Time")
                {
                    break;
                }
                long earnings = GetLootEarnings(loot[0], prices);
                long expences = long.Parse(loot[1]);
                profit += earnings - expences;
            }
            
            if (profit >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(profit)}.");
            }
        }

        public static long GetLootEarnings(string loot, int[] prices)
        {
            int earnings = 0;
            for (int i=0; i< loot.Length; i++)
            {
                if (loot[i] == '%')
                {
                    earnings += prices[0];
                }
                else if (loot[i] == '$')
                {
                    earnings += prices[1];
                }
            }
            return earnings;
        }
    }
}
