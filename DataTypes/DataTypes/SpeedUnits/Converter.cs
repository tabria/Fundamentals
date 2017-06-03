using System;

namespace SpeedUnits
{
    class Converter
    {
        static void Main()
        {
            float distanceMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());


            float speedMetersSeconds = distanceMeters / (hours * 3600 + minutes * 60 + seconds);
            float speedKmHours = (distanceMeters / 1000) / (hours + (minutes / (float)60) + (seconds / (float)3600));
            float milesPerHours = (distanceMeters / 1609) / (hours + (minutes / (float)60) + (seconds / (float)3600));

            Console.WriteLine($"{speedMetersSeconds}");
            Console.WriteLine($"{speedKmHours}");
            Console.WriteLine($"{milesPerHours}");
        }
    }
}
