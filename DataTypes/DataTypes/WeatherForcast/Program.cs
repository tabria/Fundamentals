using System;

namespace WeatherForcast
{
    class Program
    {
        static void Main()
        {
            string numberForcast = Console.ReadLine();

            string forcast = string.Empty;
            try
            {
                forcast = sbyte.Parse(numberForcast) >= sbyte.MinValue ? "Sunny" : forcast;
            }
            catch
            {
                try
                {
                    forcast = int.Parse(numberForcast) >= int.MinValue ? "Cloudy" : forcast;
                }
                catch
                {
                    try
                    {
                        forcast = long.Parse(numberForcast) >= long.MinValue ? "Windy" : forcast;
                    }
                    catch
                    {
                        try
                        {
                            forcast = double.Parse(numberForcast) >= double.MinValue ? "Rainy" : forcast;
                        }
                        catch { }
                    }
                }
            }
            Console.WriteLine(forcast);
        }
    }
}
