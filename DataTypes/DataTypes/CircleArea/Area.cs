using System;


namespace CircleArea
{
    public class Area
    {
        public static void Main()
        {

            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);

        }
    }
}
