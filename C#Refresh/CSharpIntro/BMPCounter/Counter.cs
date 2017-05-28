using System;

namespace BMPCounter
{
   public class Counter
    {
        public static void Main()
        {
            int beatsPerMin = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());

            double bars = Math.Round(beats / (double)4, 1);

            int minutes = beats/ beatsPerMin;
            double seconds = Math.Floor(60 * (beats / (double)beatsPerMin) - minutes * 60 );

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
