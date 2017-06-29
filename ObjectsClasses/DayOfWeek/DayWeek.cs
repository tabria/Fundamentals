using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DayOfWeek
{
    class DayWeek
    {
        static void Main()
        {

            string dateStr = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateStr, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
