using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepatationOneTaskOne
{
    class Sino
    {
        static void Main()
        {
            long[] allTimes = Console.ReadLine().Split(':').Select(long.Parse).ToArray();
            long stepsCount = long.Parse(Console.ReadLine());
            long stepTime = long.Parse(Console.ReadLine());

            long allSeconds = allTimes[2] + allTimes[1] * 60 + allTimes[0] * 60 * 60;
            long stepsTime = stepTime * stepsCount;
            allSeconds += stepsTime;

            long seconds = allSeconds % 60;
            long minutes = (allSeconds / 60) % 60;
            long hours = ((allSeconds /60)/60 ) % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
