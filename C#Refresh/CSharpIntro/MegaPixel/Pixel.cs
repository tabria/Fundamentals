using System;

namespace MegaPixel
{
   public class Pixel
    {
        public static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double megaPixel = Math.Round((width*height)/1000000.0, 1);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, megaPixel);

        }
    }
}
