using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main()
        {

            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine()); 

            int portionCount = (int)Math.Ceiling(guests/6.0);
            int bananaQuantity = portionCount * 2;
            int eggsQuantity = portionCount * 4;
            double berriesKg = portionCount * 0.2;

            decimal totalPrice = bananaPrice * (decimal)bananaQuantity + eggPrice * (decimal)eggsQuantity + berriesPrice * (decimal)berriesKg;

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - cash):f2}lv more.");
            }
        }
    }
}
