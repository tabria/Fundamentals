using System;

namespace MaxMethod
{
    class Program
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int maxOneTwo = GetMax(numberOne, numberTwo);
            int maxAll = GetMax(maxOneTwo, numberThree);

            Console.WriteLine(maxAll);
        }

        public static int GetMax(int valueOne, int valueTwo)
        {
            if (valueOne >= valueTwo)
            {
                return valueOne;
            }
            return valueTwo;
        }
    }
}
