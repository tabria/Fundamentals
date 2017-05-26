using System;

namespace Rectangle
{
   public class Area
    {
        public static void Main()
        {

            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}",(width * height));


        }
    }
}
