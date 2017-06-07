using System;


namespace MathPower
{
    class Power
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double numberPower = GetNumberPower(number, power);

            Console.WriteLine(numberPower);

        }

        private static double GetNumberPower(double number, double power)
        {
            double result = 1.0;
            for (int i =0; i<Math.Abs(power); i++)
            {
                result *= number;
            }
            if (power < 0)
            {
                result = 1 / result;
            }
            return result;
        }
    }
}
