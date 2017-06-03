using System;

namespace ThePhotographer
{
    class PhotoMaker
    {
        static void Main()
        {
            int picturesCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimeSeconds = int.Parse(Console.ReadLine());


            long filterPicturesTime = picturesCount * (long)filterTime;
            int usefullPictures = (int)Math.Ceiling( picturesCount * (filterFactor / 100.0) );
            long fullUploadTime = usefullPictures * (long)uploadTimeSeconds;

            long totalTime = filterPicturesTime + fullUploadTime;


            long seconds = totalTime % 60;
            long totalMinutes = totalTime / 60;
            long minutes = totalMinutes % 60;
            long totalHours = totalMinutes / 60;
            long hours = totalHours % 24;
            long days = totalHours / 24;



            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}", days, hours, minutes, seconds);

            //Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(new string('d', 1) + @"\:hh\:mm\:ss"));

        }
    }
}
