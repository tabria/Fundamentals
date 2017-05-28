using System;

namespace Calorie
{
    public class Counter
    {
        public static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());


            int totalCalories = 0;
            for (int i =0; i<cycles; i++)
            {
                string ingredient = Console.ReadLine();
                switch (ingredient.ToLower())
                {
                    case "cheese": totalCalories += 500; break;
                    case "tomato sauce": totalCalories += 150; break;
                    case "salami": totalCalories += 600; break;
                    case "pepper": totalCalories += 50; break;
                    default: break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
