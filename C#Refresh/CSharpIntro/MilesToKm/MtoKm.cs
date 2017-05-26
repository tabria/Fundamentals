using System;


namespace MilesToKm
{
    public class MtoKm
    {
        public static void Main()
        {
            var mile = double.Parse(Console.ReadLine());

            var km = mile * 1.60934;

            Console.WriteLine($"{km:F2}");

        }
    }
}
