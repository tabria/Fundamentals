using System;
using System.Linq;


namespace UpgradedMatcher
{
    class MatcherV2
    {
        static void Main()
        {
            string[] nameProducts = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string[] orderInfo = Console.ReadLine().Split(' ').ToArray();
                if (orderInfo[0] == "done")
                {
                    break;
                }

                int productIndex = Array.IndexOf(nameProducts, orderInfo[0]);

                long orderQuantity = long.Parse(orderInfo[1]);
                long availableQuantity = GetAvailableQuantity(quantities, productIndex, orderQuantity);
                
       
                if (availableQuantity >= orderQuantity)
                {
                    quantities[productIndex] -= orderQuantity;
                    decimal productCosts = orderQuantity * prices[productIndex];
                    Console.WriteLine($"{orderInfo[0]} x {orderInfo[1]} costs {productCosts:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {orderInfo[0]}");
                }
            }
        }

        public static long GetAvailableQuantity(long[] quantities ,int index, long orderQuantity)
        {
            long quantity = 0;
            try
            {
                quantity = quantities[index];
            }
            catch { };
            return quantity;
        }
    }
}
