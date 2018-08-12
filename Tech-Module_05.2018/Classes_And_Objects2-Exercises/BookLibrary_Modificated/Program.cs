using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                string isbn = input[4];
                decimal price = decimal.Parse(input[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);

                books.Add(book);
            }

            DateTime filterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                CultureInfo.InvariantCulture);

            books
               .Where(b => b.ReleaseDate > filterDate)
               .OrderBy(b => b.ReleaseDate)
               .ThenBy(b => b.Title)
               .Select(b => $"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}")
               .ToList()
               .ForEach(Console.WriteLine);

            //или:
            //List<Book> filteredBooks = books.Where(b => b.ReleaseDate > filterDate)
            //    .OrderBy(b => b.ReleaseDate)
            //    .ThenBy(b => b.Title)
            //    .ToList();

            //foreach (Book book in filteredBooks)
            //{
            //    Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            //}




        }

    }
    }


    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }
    }

