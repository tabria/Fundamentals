using System;
using System.Collections.Generic;
using System.Linq;

namespace DistanceBetweenPoints
{

    class Distance
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

        }

        static void Main()
        {
            Point pointA = ReadPoint();
            Point pointB = ReadPoint();

            double distance = CalcDistance(pointA, pointB);

            Console.WriteLine($"Distance: {distance:f3}");

        }

        static double CalcDistance(Point pointA, Point pointB)
        {
            int deltaX = Math.Abs(pointA.X - pointB.X);
            int deltaY = Math.Abs(pointA.Y - pointB.Y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point ReadPoint()
        {
            int[] coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point newPoint = new Point();
            newPoint.X = coords[0];
            newPoint.Y = coords[1];

            return newPoint;

        }
    }
}
