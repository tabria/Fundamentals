using System;

namespace MasterNumbers
{
    class Master
    {
        static void Main()
        {
            int endRange = int.Parse(Console.ReadLine());


            for (int i=1; i <= endRange; i++)
            {
                if (isSymetric(i))
                {
                    
                    if (isDividedBySeven(i))
                    {
                        if (ContainEvenDigit(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

        }

        public static bool isDividedBySeven(int i)
        {
            int sum = SumOfDigits(i);
            double sumBySeven = sum / 7.0;
            if (Math.Abs(sumBySeven - (int)sumBySeven) < 0.0001)
            {
                return true;
            }

            return false;
        }

        public static bool ContainEvenDigit(int number)
        {
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }

        public static bool isSymetric(int number)
        {
            int mirrorNumber = GetMirrorNumber(number);
            if (mirrorNumber == number)
            {
                return true;
            }
            return false;
        }

        public static int GetMirrorNumber(int number)
        {
            int mirrorNumber = 0;
            while (number > 0)
            {
                mirrorNumber = mirrorNumber*10 + number % 10;
                number /= 10;
            }

            return mirrorNumber;
        }
    }
}
