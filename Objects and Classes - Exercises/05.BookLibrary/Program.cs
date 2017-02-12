using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Library lib = new Library
            {
                Name = "bookStorage",
                books = new List<Books>()
            };

            for (int i = 0; i < n; i++)
            {
                List<string> info = Console.ReadLine().Split(' ').ToList();

                string title = info[0];
                string author = info[1];
                decimal price = decimal.Parse(info[5]);
                if (lib.books.All(a => a.Author != author))
                {
                    Books newBook = new Books
                    {
                        Author = author,
                        Price = price
                    };

                    lib.books.Add(newBook);
                }
                else
                {
                    Books toUpgrade = lib.books.First(a => a.Author == author);
                    toUpgrade.Price += price;
                }
            }
            foreach (Books book in lib.books
                                      .OrderByDescending(p => p.Price)
                                      .ThenBy(a => a.Author))
            {
                Console.WriteLine($"{book.Author} -> {book.Price:f2}");
            }
        }
    }
}

class Library
{
    public string Name { get; set; }
    public List<Books> books { get; set; }
}

class Books
{
    public string Author { get; set; }
    public decimal Price { get; set; }
}