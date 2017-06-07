using System;

class PriceChangeAlert
{
    static void Main()
    {
        int cycles = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());

        double lastPrice = double.MinValue;

        for (int i = 0; i < cycles; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            if (lastPrice == double.MinValue)
            {
                lastPrice = currentPrice;
                continue;
            }

            double difference = GetDifference(lastPrice, currentPrice);
            bool isSignificant = isDifferenceSignificant(difference, threshold);

            string message = Get(currentPrice, lastPrice, difference, isSignificant);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double difference, bool isSignificant)
    {
        string changeType = string.Empty;
        if (difference == 0)
        {
            changeType = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificant)
        {
            changeType = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (isSignificant && (difference > 0))
        {
            changeType = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificant && (difference < 0))
        {
            changeType = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
            
        return changeType;
    }

    private static bool isDifferenceSignificant(double difference, double threshold)
    {
        if (threshold > Math.Abs(difference))
        {
            return false;
        }
        return true;
    }

    private static double GetDifference(double lastPrice, double currentPrice)
    {
        return (currentPrice - lastPrice)/ lastPrice;
    }
}
