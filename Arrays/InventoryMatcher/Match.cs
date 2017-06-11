using System;
using System.Linq;

namespace InventoryMatcher
{
    class Match
    {
        static void Main()
        {
            string[] nameProducts = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] prices = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "done")
                {
                    break;
                }
                int index = Array.IndexOf(nameProducts, name);
                Console.WriteLine($"{name} costs: {prices[index]}; Available quantity: {quantities[index]}");
            }

        }
        
    }
}
