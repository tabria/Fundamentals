using System;


namespace Cube_Properties
{
    class Cube
    {
        static void Main()
        {

            double edge = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();


            Console.WriteLine("{0:f2}",GetResult(edge, parameter));
        }

        public static double GetResult (double edge, string parameter)
        {
            double result = 0.0;
            switch (parameter)
            {
                case "face": result = CalculateFaceDiagonal(edge); break;
                case "space": result = CalculateSpaceDiagonal(edge); break;
                case "volume": result = CalculateVolume(edge); break;
                case "area": result = CalculateArea(edge); break;
                default: break;
            }
            return result;
        }

        public static double CalculateArea(double edge)
        {
            return 6 * Math.Pow(edge, 2);
        }

        public static double CalculateVolume(double edge)
        {
            return Math.Pow(edge, 3);
        }

        public static double CalculateSpaceDiagonal(double edge)
        {
            return Math.Sqrt(3 * Math.Pow(edge, 2));
        }

        public static double CalculateFaceDiagonal(double edge)
        {
            return Math.Sqrt(2 * Math.Pow(edge, 2));
        }
    }
}
