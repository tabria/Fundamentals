using System;


namespace LongerLine
{
    class LongLine
    {
        static void Main()
        {
            double pointAx1 = double.Parse(Console.ReadLine());
            double pointAy1 = double.Parse(Console.ReadLine());
            double pointAx2 = double.Parse(Console.ReadLine());
            double pointAy2 = double.Parse(Console.ReadLine());
            double pointBx1 = double.Parse(Console.ReadLine());
            double pointBy1 = double.Parse(Console.ReadLine());
            double pointBx2 = double.Parse(Console.ReadLine());
            double pointBy2 = double.Parse(Console.ReadLine());

            double lineALength = GetLineLength(pointAx1, pointAy1, pointAx2, pointAy2);
            double lineBLength = GetLineLength(pointBx1, pointBy1, pointBx2, pointBy2);

            if (lineALength >= lineBLength)
            {
                PrintLineClosestPoint(pointAx1, pointAy1, pointAx2, pointAy2);
                return;
            }
            PrintLineClosestPoint(pointBx1, pointBy1, pointBx2, pointBy2);
            return;

        }

        public static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double pointAX = CombineCoordinates(x1, x2);
            double pointAY = CombineCoordinates(y1, y2);

            return GetDistance(pointAX, pointAY);
        }

        public static void PrintLineClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distanceA = GetDistance(x1, y1);
            double distanceB = GetDistance(x2, y2);

            if (distanceA <= distanceB)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                return;
            }
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            return;
        }

        public static double CombineCoordinates(double x1, double x2)
        {
            return Math.Abs(x1) + Math.Abs(x2);
        }

        public static double GetDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
