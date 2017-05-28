using System;

namespace ChooseDrink
{
    public class Drink
    {
        public static void Main()
        {
            string profession = Console.ReadLine();
            string drink = "Tea";

            if(profession == "Athlete")
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

            Console.WriteLine(drink);

        }
    }
}
