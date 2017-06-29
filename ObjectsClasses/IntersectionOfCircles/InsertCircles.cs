using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectionOfCircles
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class InsertCircles
    {
        static void Main()
        {
            Circle circleA = GetCirclePoints();
            Circle circleB = GetCirclePoints();

            Console.WriteLine(isIntersect(circleA, circleB) ? "Yes" : "No");

        }

        static bool isIntersect(Circle circleA, Circle circleB)
        {
            double centerDistance = CalculateDistance(circleA, circleB);
            int circleCombineRadius = circleA.Radius + circleB.Radius;
            return circleCombineRadius >= centerDistance;

        }

        static double CalculateDistance(Circle circleA, Circle circleB)
        {
            double deltaX = Math.Abs(circleA.Center.X - circleB.Center.X);
            double deltaY = Math.Abs(circleA.Center.Y - circleB.Center.Y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Circle GetCirclePoints()
        {
            int[] arrCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point centerCoords = new Point();
            centerCoords.X = arrCircle[0];
            centerCoords.Y = arrCircle[1];

            Circle currentCircle = new Circle();
            currentCircle.Center = centerCoords;
            currentCircle.Radius = arrCircle[2];

            return currentCircle;
        }
    }
}
