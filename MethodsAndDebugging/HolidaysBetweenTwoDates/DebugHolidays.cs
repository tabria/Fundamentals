using System;
using System.Globalization;

namespace HolidaysBetweenTwoDates
{
    class DebugHolidays
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                holidaysCount = (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) ? holidaysCount + 1 : holidaysCount;
            }
               
            Console.WriteLine(holidaysCount);
        }
    }
}
