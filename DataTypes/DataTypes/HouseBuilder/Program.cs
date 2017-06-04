using System;


namespace HouseBuilder
{
    class Program
    {
        static void Main()
        {

            sbyte sbytePrice = 0;
            int intPrice = 0;
            for(int i =0; i<2; i++)
            {
                string rawPrice = Console.ReadLine();

                try
                {
                    sbytePrice = sbyte.Parse(rawPrice);
                }
                catch
                {
                    intPrice = int.Parse(rawPrice);
                }
            }


            int totalSbytePrice = 4 * (int)sbytePrice;
            long totalIntPrice = 10 * (long)intPrice;

            Console.WriteLine(totalSbytePrice + totalIntPrice);
        }
    }
}
