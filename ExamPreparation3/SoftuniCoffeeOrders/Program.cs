using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {

            int orders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;
            for(int i=0; i<orders; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                int[] date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(date[2], date[1]);
                var price = daysInMonth * capsulesCount * capsulePrice;

                totalPrice += price;

              Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

           Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
