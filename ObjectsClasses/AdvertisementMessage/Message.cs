using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvertisementMessage
{
    class Message
    {
        static void Main()
        {

            int messagesCount = int.Parse(Console.ReadLine());
            Random rand = new Random();

            PrintMessage(messagesCount, rand);
        }

        public static void PrintMessage(int messagesCount, Random rand)
        {
            for(int i =0; i<messagesCount; i++)
            {
                Console.WriteLine(ComposeMessage(rand));
            }
        }

        public static string ComposeMessage(Random rand)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            

            string phrase = phrases[rand.Next(phrases.Length - 1)];
            string feel = events[rand.Next(events.Length - 1)];
            string author = authors[rand.Next(authors.Length-1)];
            string city = cities[rand.Next(cities.Length - 1)];

            return phrase + " " + feel + " " + " " + author + " - " + city;
        }
    }
}
