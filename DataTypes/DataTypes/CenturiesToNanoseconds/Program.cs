using System;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());

            short years = (short)(centuries * 100);
            int days = (int)(years*365.2422);
            uint hours = (uint)(days * 24);
            long minutes = hours * 60;
            long seconds = minutes*60;
            double milliseconds = seconds * 10E+2;
            double microseconds = milliseconds * 10E+2;
            double nanoseconds = microseconds * 10E+2;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds:f0} milliseconds = {microseconds:f0} microseconds = {nanoseconds:f0} nanoseconds");

        }
    }
}
