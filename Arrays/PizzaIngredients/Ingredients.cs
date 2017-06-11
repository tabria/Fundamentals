using System;
using System.Linq;

namespace PizzaIngredients
{
    class Ingredients
    {
        static void Main()
        {

            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int ingredientLength = int.Parse(Console.ReadLine());

            int countIngredients = 0;
            string usedIngredients = string.Empty;
            for (int i=0; i<arr.Length; i++)
            {
                if (countIngredients > 9)
                {
                    break;
                }
                if (arr[i].Length == ingredientLength)
                {
                    countIngredients++;
                    string spacer = countIngredients > 1 ? ", " : string.Empty;
                    usedIngredients += spacer + arr[i];
                    Console.WriteLine($"Adding {arr[i]}.");
                }
            }

            Console.WriteLine($"Made pizza with total of {countIngredients} ingredients.");
            Console.WriteLine($"The ingredients are: {usedIngredients}.");

        }
    }
}
