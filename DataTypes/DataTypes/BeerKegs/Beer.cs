using System;

namespace BeerKegs
{
    class Beer
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());

            string biggestKeg = string.Empty;
            double maxVolume = double.MinValue;
            for(int i=0; i<cycles; i++)
            {

                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);

        }
    }
}
