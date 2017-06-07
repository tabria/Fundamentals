using System;

namespace GeometryCalculator
{
    class Calculator
    {
        static void Main()
        {
            string figureType = Console.ReadLine();


            double result = 0.0;
            switch (figureType)
            {
                case "triangle": result = GetTriangleArea(); break;
                case "square": result = GetSquareArea(); break;
                case "rectangle": result = GetRectangleArea(); break;
                case "circle": result = GetcircleArea(); break;
                default: break;
            }

            Console.WriteLine("{0:f2}", result);
        }

        public static double GetcircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            return Math.PI * Math.Pow(radius, 2);
        }

        public static double GetRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return width * height;
        }

        public static double GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());

            return side * side;
        }

        public static double GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            return (side * height ) / 2;
        }
    }
}
