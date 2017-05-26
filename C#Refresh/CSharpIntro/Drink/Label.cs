using System;

namespace Drink
{
   public class Label
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            var totalEnergy = energy * (volume/100.0);
            var totalSugar = sugar * (volume/(double)100);

            Console.WriteLine($"{volume}ml {name}:" + Environment.NewLine + $"{totalEnergy}kcal, {totalSugar}g sugars");


        }
    }
}
