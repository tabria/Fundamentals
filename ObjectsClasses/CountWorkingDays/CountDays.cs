using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace CountWorkingDays
{
    class CountDays
    {
        static void Main()
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(1, 1, 1),
                new DateTime(1, 3, 3),
                new DateTime(1, 5, 1),
                new DateTime(1, 5, 6),
                new DateTime(1, 5, 24),
                new DateTime(1, 9, 6),
                new DateTime(1, 9, 22),
                new DateTime(1, 11, 1),
                new DateTime(1, 12, 24),
                new DateTime(1, 12, 25),
                new DateTime(1, 12, 26)
            };

            DateTime startDate = GetInputDate();
            DateTime endDate = GetInputDate();

            var workingDays = 0;
            for(var currentDate = startDate; currentDate<= endDate; currentDate = currentDate.AddDays(1))
            {
                if (!isHoliday(currentDate, holidays))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }

        public static bool isHoliday(DateTime currentDate, DateTime[] holidays)
        {
            return holidays.Any(h => h.Day == currentDate.Day && h.Month == currentDate.Month)
                   || (currentDate.DayOfWeek == DayOfWeek.Saturday)
                   || (currentDate.DayOfWeek == DayOfWeek.Sunday);
        }

        public static DateTime GetInputDate()
        {
            return DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
    }
}
