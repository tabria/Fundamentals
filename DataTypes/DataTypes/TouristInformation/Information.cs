using System;

namespace TouristInformation
{
    class Information
    {
        static void Main()
        {
            string imperialUnit = Console.ReadLine();
            double imperialValue = double.Parse(Console.ReadLine());

            string metricUnit = String.Empty;
            double convertedValue = 0.0;
            switch(imperialUnit)
            {
                case "miles":
                    metricUnit = "kilometers";
                    convertedValue = imperialValue * 1.6;
                    break;
                case "feet":
                    metricUnit = "centimeters";
                    convertedValue = imperialValue * 30;
                    break;
                case "inches":
                    metricUnit = "centimeters";
                    convertedValue = imperialValue * 2.54;
                    break;
                case "yards":
                    metricUnit = "meters";
                    convertedValue = imperialValue * 0.91;
                    break;
                case "gallons":
                    metricUnit = "liters";
                    convertedValue = imperialValue * 3.8;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{imperialValue} {imperialUnit} = {convertedValue:f2} {metricUnit}");
        }
    }
}
