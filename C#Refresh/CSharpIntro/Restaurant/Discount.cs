using System;

namespace Restaurant
{
    public class Discount
    {
       public static void Main()
        {
            int peopleQuantity = int.Parse(Console.ReadLine());
            string discountType = Console.ReadLine();


            int price    = 0;

            if (peopleQuantity <= 50)
            {
                price = 2500;
            }
            else if(peopleQuantity <= 100)
            {
                price = 5000;
            }
            else if(peopleQuantity <= 120)
            {
                price = 7500;
            }

            double amountToPay = 0.0;
            switch (discountType)
            {
                case "Normal":
                    amountToPay = (price + 500) * 0.95;
                    break;

                case "Gold":
                    amountToPay = (price + 750) * 0.9;
                    break;

                case "Platinum":
                    amountToPay = (price + 1000) * 0.85;
                    break;

                default:
                    break;
            }

            double pricePerPerson = amountToPay / peopleQuantity;

            string hallType = string.Empty;
            if(peopleQuantity <= 50)
            {
                hallType = "Small Hall";
            } 
            else if(peopleQuantity <=100)
            {
                hallType = "Terrace";
            }
            else if(peopleQuantity <= 120)
            {
                hallType = "Great Hall";
            }

            if (peopleQuantity > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }

        }
    }
}
