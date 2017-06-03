using System;


namespace CompareFloats
{
    class CompareF
    {
        static void Main()
        {
            double floatOne = double.Parse(Console.ReadLine());
            double floatTwo = double.Parse(Console.ReadLine());



            Console.WriteLine(Math.Abs(floatOne -floatTwo) <= 0.000001 ? "True" : "False");
 


        }
    }
}
