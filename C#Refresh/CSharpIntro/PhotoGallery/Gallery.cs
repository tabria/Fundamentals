using System;

namespace PhotoGallery
{
    public class Gallery
    {
        public static void Main()
        {

            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height =int.Parse(Console.ReadLine());


            string sizeExtention = string.Empty;
            if (photoSize < 1000)
            {
                sizeExtention = "B";
            }
            else if(photoSize < 1000000)
            {
                photoSize /= 1000;
                sizeExtention = "KB";
            } 
            else
            {
                photoSize /= 1000000;
                sizeExtention = "MB";
            }




            string orientation = "square";
            if (width < height)
            {
                orientation = "portrait";
            }
            else if(width > height)
            {
                orientation = "landscape";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:d2}:{minutes:D2}");
            Console.WriteLine($"Size: {photoSize}{sizeExtention}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");

        }
    }
}
