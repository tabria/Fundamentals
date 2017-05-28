using System;

namespace Cake
{
    public class Ingredient
    {
        public static void Main()
        {

            int countIngredient = 0;
            while (true)
            {
                string cakeIngredient = Console.ReadLine();
                if (cakeIngredient == "Bake!")
                {
                    break;
                }

                Console.WriteLine($"Adding ingredient {cakeIngredient}.");
                countIngredient++;
            }

            Console.WriteLine($"Preparing cake with {countIngredient} ingredients.");
        }
    }
}
