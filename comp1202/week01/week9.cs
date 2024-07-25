// using System;
// using System.Collections.Generic;

// class Book
// {
//     public string Title;
//     public string Author;
//     public int YearPublished;
//     public List<string> Genres;
//     public string Isbn;

//     public Book(string title, string author)
//     {
//         Title = title;
//         Author = author;
//         Genres = new List<string>(); // List to add and remove genres
//         Isbn = "N/A";
//     }

//     public Book(string title, string author, int yearPublished, string[] genres)
//     {
//         Title = title;
//         Author = author;
//         YearPublished = yearPublished;
//         Genres = new List<string>(genres);
//         Isbn = "N/A";
//     }

//     public void AddGenre(string genre)
//     {
//         Genres.Add(genre);
//     }

//     public bool RemoveGenre(string genre)
//     {
//         return Genres.Remove(genre);
//     }

//     public override string ToString()
//     {
//         return $"Title: {Title}, Author: {Author}, Year Published: {YearPublished}, Genres: {string.Join(", ", Genres)}, ISBN: {Isbn}";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Book book1 = new Book("Harry Potter", "David Beckham");
//         book1.AddGenre("Fiction");
//         book1.AddGenre("Adventure");
//         book1.Isbn = "978-3-16-148410-0";

//         string[] genres = { "Fiction", "Adventure" };
//         Book book2 = new Book("Twilight", "Stephenie Meyer", 2015, genres);

//         Console.WriteLine(book1.ToString());
//         Console.WriteLine(book2.ToString());

//         bool genreRemoved = book1.RemoveGenre("Fiction");
//         Console.WriteLine($"Genre removed from the book '{book1.Title}', {genreRemoved}");
//         Console.WriteLine(book1.ToString());
//     }
// }
