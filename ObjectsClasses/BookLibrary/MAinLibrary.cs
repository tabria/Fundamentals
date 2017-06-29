using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string IsbnNumber { get; set; }
        public decimal Price { get; set; }

    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class MAinLibrary
    {
        static void Main()
        {

           

            Library lib = new Library { Name = "Lib", Books = FillBooks() };

            Dictionary<string, decimal> results = new Dictionary<string, decimal>();

            foreach( var bp in lib.Books)
            {
                if (!results.ContainsKey(bp.Author))
                {
                    results[bp.Author] = bp.Price;
                }
                else
                {
                    results[bp.Author] += bp.Price;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, results.OrderByDescending(d=>d.Value).ThenBy(s=>s.Key).Select(m=>m.Key + " -> " + $"{ m.Value:f2}")));
        }

        static List<Book> FillBooks()
        {
            int cycles = int.Parse(Console.ReadLine());

            List<Book> allBooks = new List<Book>();

            for (int i=0; i<cycles; i++)
            {
                string[] currentBook = Console.ReadLine().Split(' ').ToArray();
                Book books = new Book
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher =currentBook[2],
                    ReleaseDate = DateTime.ParseExact(currentBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IsbnNumber = currentBook[4],
                    Price = decimal.Parse(currentBook[5])
                };
                allBooks.Add(books);
            }
            return allBooks;
        }
    }
}
