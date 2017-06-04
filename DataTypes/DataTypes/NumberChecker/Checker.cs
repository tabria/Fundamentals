using System;

namespace NumberChecker
{
    class Checker
    {
        static void Main()
        {

            try
            {
                long currentInt = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch
            {
                Console.WriteLine("floating-point");
            }


        }
    }
}
