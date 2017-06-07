using System;


namespace CalculateTriangleArea
{
    class CalculateArea
    {
        static void Main()
        {
            double baseTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());


            double area = TriangleArea(baseTriangle, heightTriangle);
            Console.WriteLine(area);

        }

        private static double TriangleArea(double baseTriangle, double heightTriangle)
        {
            return (baseTriangle * heightTriangle) / 2;
        }
    }
}
