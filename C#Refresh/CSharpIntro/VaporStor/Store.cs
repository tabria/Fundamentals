using System;


namespace VaporStor
{
    public class Store
    {
        public static void Main()
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double initialBalance = currentBalance;

            while (true)
            {
                string buyGame = Console.ReadLine();
                if (buyGame == "Game Time")
                {
                    break;
                }

                double gamePrice = 0.0;
                bool isFound = true;
                switch (buyGame)
                {
                    case "OutFall 4":                  gamePrice = 39.99; break;
                    case "CS: OG":                     gamePrice = 15.99; break;
                    case "Zplinter Zell":              gamePrice = 19.99; break;
                    case "Honored 2":                  gamePrice = 59.99; break;
                    case "RoverWatch":                 gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:                           isFound = false;   break;
                }

                if (!isFound)
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (gamePrice > currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }

                Console.WriteLine($"Bought {buyGame}");

                currentBalance -= gamePrice;
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

            }
            double spent = initialBalance - currentBalance;
            Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${currentBalance:F2}");

        }
    }
}
