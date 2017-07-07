using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyKm = decimal.Parse(Console.ReadLine());

            var maxRunners = days * trackCapacity > runners ? runners : days * trackCapacity;
            double trackLenghtKm = trackLength / 1000.0;
            decimal moneyRunners = moneyKm * (decimal)trackLenghtKm * averageLaps * maxRunners;
            Console.WriteLine($"Money raised: {moneyRunners:f2}");
        }
    }
}
