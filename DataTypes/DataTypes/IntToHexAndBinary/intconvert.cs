using System;


namespace IntToHexAndBinary
{
    class IntConvert
    {
        static void Main()
        {
            int intConvert = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(intConvert, 16).ToUpper());
            Console.WriteLine(Convert.ToString(intConvert, 2).ToUpper());

        }
    }
}
