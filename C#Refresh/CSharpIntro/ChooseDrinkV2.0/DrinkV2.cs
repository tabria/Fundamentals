using System;

namespace ChooseDrinkV2._0
{
    public class DrinkV2
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            double drinkQuantity = double.Parse(Console.ReadLine());
            string drink = "Tea";
            double drinkPrice = 0.0;

            if (profession == "Athlete")
            {
                drink = "Water";
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }

            switch (drink)
            {
                case "Water":   drinkPrice = 0.70; break;
                case "Coffee":  drinkPrice = 1.00; break;
                case "Beer":    drinkPrice = 1.70; break;
                default:        drinkPrice = 1.20; break;
            }

            double totalPrice = drinkQuantity * drinkPrice;

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");


        }
    }
}
