using System;
using System.Collections.Generic;
using System.Linq;


namespace ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class ClosestPoints
    {
        static void Main()
        {
            Point[] allPoints = GetAllPoints();
            Point[] closestPoints = GetClosestPoints(allPoints);

            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
            
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        static void PrintDistance(Point[] closestPoints)
        {
            double distance = GetDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static Point[] GetClosestPoints(Point[] allPoints)
        {
            double minDistance = double.MaxValue;
            Point[] closePoints = new Point[2];

            for(int i=0; i<allPoints.Length; i++)
            {
                for(int k=i+1; k<allPoints.Length; k++)
                {
                    double currentDistance = GetDistance(allPoints[i], allPoints[k]);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closePoints[0] = allPoints[i];
                        closePoints[1] = allPoints[k];

                    }
                }
            }

            return closePoints;
        }

        static double GetDistance(Point point1, Point point2)
        {
            int deltaX = Math.Abs(point1.X - point2.X);
            int deltaY = Math.Abs(point1.Y - point2.Y);

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        static Point[] GetAllPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] currentPoints = new Point[n];
            for(int i=0; i<n; i++)
            {
                currentPoints[i] = GetAllPoint();
            }

            return currentPoints;
        }

        static Point GetAllPoint()
        {
            int[] coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point point = new Point();
            point.X = coords[0];
            point.Y = coords[1];

            return point;
        }
    }
}
