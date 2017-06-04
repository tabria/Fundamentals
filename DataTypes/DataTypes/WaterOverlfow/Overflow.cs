using System;


namespace WaterOverlfow
{
    class Overflow
    {
        static void Main()
        {
            int cycles = int.Parse(Console.ReadLine());
            int capacity = 0;
            int maxCapacity = 255;

            for (int i = 0; i < cycles; i++)
            {
                int addWater = int.Parse(Console.ReadLine());

                if ((capacity + addWater) <= maxCapacity)
                {
                    capacity += addWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
