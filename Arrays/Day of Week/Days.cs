using System;

namespace Day_of_Week
{
    class Days
    {
        static void Main()
        {
            int dayNumber = int.Parse(Console.ReadLine());
            string[] DayName = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            Console.WriteLine( (dayNumber < 1 || dayNumber > 7) ? "Invalid Day!" : DayName[dayNumber-1] );
        }
    }
}
