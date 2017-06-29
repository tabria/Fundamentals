using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace BookLibraryModification
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

    class LibModification
    {
        static void Main()
        {
            Library lib = new Library { Name = "Lib", Books = FillBooks() };
            DateTime dateBorder = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(string.Join(Environment.NewLine, lib.Books.Where(dt=>dt.ReleaseDate > dateBorder).OrderBy(date=>date.ReleaseDate).ThenBy(t=>t.Title).Select(s=>s.Title + " -> " + s.ReleaseDate.ToString("dd.MM.yyyy"))));
        }

        static List<Book> FillBooks()
        {
            int cycles = int.Parse(Console.ReadLine());

            List<Book> allBooks = new List<Book>();

            for (int i = 0; i < cycles; i++)
            {
                string[] currentBook = Console.ReadLine().Split(' ').ToArray();
                Book books = new Book
                {
                    Title = currentBook[0],
                    Author = currentBook[1],
                    Publisher = currentBook[2],
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
