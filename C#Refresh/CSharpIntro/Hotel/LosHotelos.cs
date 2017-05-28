using System;

namespace Hotel
{
   public  class LosHotelos
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;
            switch (month)
            {
                case "May":
                case "October":
                    {
                        studioPrice = 50;
                        doublePrice = 65;
                        suitePrice = 75;
                    }
                    break;

                case "June":
                case "September":
                    {
                        studioPrice = 60;
                        doublePrice = 72;
                        suitePrice = 82;
                    }
                    break;

                case "July":
                case "August":
                case "December":
                    {
                        studioPrice = 68;
                        doublePrice = 77;
                        suitePrice = 89;
                    }
                    break;
            }
            if ( (month == "May" || month == "October") && nightCount > 7)
            {
                studioPrice = studioPrice * 0.95;
            } 
            else if ( (month == "June" || month == "September") && nightCount > 14)
            {
                doublePrice = doublePrice * 0.9;
            }
            else if ((month == "July" || month == "August" || month == "December") && nightCount > 14)
            {
                suitePrice = suitePrice * 0.85;
            }

            double studioTotalPrice = studioPrice * nightCount;
            if (nightCount > 7 && (month == "September" || month == "October"))
            {
                studioTotalPrice = studioPrice * (nightCount - 1);
            }

            double doubleTotalPrice = doublePrice * nightCount;
            double suiteTotalPrice = suitePrice * nightCount;

            Console.WriteLine("Studio: {0:F2} lv.", studioTotalPrice);
            Console.WriteLine("Double: {0:F2} lv.", doubleTotalPrice);
            Console.WriteLine("Suite: {0:F2} lv.", suiteTotalPrice);

        }
    }
}
