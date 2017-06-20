using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class CardHands
    {
        static void Main()
        {

            Dictionary<string, List<string>> personCards = new Dictionary<string, List<string>>();
            Dictionary<char, int> cardPowerValue = new Dictionary<char, int>
                {
                    { 'J', 11}, { 'Q', 12}, { 'K', 13}, { 'A', 14}
                };
            char[] cardTypeValue = { 'C', 'D', 'H', 'S'};
            char[] delimiter = { ',', ' ' };

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }

                var arr = input.Split(':');
                string personName = arr[0].Trim();
                string[] currentPlayerCards = arr[1].Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

                AddCardsToPlayer(personCards, currentPlayerCards, personName);
            }

            PrintSuCardsValue(personCards, cardPowerValue, cardTypeValue);
        }

        public static void PrintSuCardsValue(Dictionary<string, List<string>> personCards, Dictionary<char, int> cardPowerValue, char[] cardTypeValue)
        {
            foreach (var kvp in personCards)
            {
                int sumCardValue = 0;
                var personAllCards = kvp.Value;
                for (int i = 0; i < personAllCards.Count(); i++)
                {
                    string card = personAllCards[i];

                    int currentPowerValue = GetPowerValue(card, cardPowerValue);
                    int currentTypeValue = Array.IndexOf(cardTypeValue, card[card.Length - 1]) + 1;

                    sumCardValue += currentPowerValue * currentTypeValue;
                }

                Console.WriteLine($"{kvp.Key}: {sumCardValue}");
            }
        }

        public static void AddCardsToPlayer(Dictionary<string, List<string>> personCards, string[] currentPlayerCards, string personName)
        {
            for (int i = 0; i < currentPlayerCards.Length; i++)
            {
                string card = currentPlayerCards[i];
                if (personCards.ContainsKey(personName))
                {
                    if (!personCards[personName].Contains(card))
                    {
                        personCards[personName].Add(card);
                    }
                }
                else
                {
                    personCards[personName] = new List<string> { card };

                }
            }
        }

        public static int GetPowerValue(string card, Dictionary<char, int> cardPowerValue)
        {
            int powerValue = 0;
            try
            {
                powerValue = int.Parse(card.Remove(card.Length - 1));
            }
            catch
            {
                powerValue = cardPowerValue[card[0]];
            }

            return powerValue;
        }
    }
}
