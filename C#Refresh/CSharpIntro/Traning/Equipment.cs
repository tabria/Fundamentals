using System;

namespace Traning
{
    public class Equipment
    {
        public static void Main()
        {
           int budget = int.Parse(Console.ReadLine());
           int cycles = int.Parse(Console.ReadLine());

            decimal subtotal = 0;
            for(int i=1; i<=cycles; i++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                subtotal = subtotal + (itemCount * itemPrice);

                string plural = itemCount > 1 ? "s" : string.Empty;
                Console.WriteLine($"Adding {itemCount} {itemName}{plural} to cart.");
            }

            decimal moneyDifference = budget - subtotal;

            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if(moneyDifference <0)
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", Math.Abs(moneyDifference));
            }
            else
            {
                Console.WriteLine($"Money left: ${moneyDifference:f2}");
            }

        }
    }
}
