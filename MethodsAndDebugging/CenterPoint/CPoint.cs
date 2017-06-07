using System;


namespace CenterPoint
{
    class CPoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            

            PrintCoordsClosestPoint(x1, y1, x2, y2);

        }

        private static void PrintCoordsClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distanceA = GetDistance(x1, y1);
            double distanceB = GetDistance(x2, y2);
            
            if (distanceA < distanceB)
            {
                Console.WriteLine($"({x1}, {y1})");
                return;
            }
            Console.WriteLine($"({x2}, {y2})");
        }

        public static double GetDistance (double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }


    }
}
