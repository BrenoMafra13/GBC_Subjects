// public class Author
// {
//     private static int nextId = 0;
//     private readonly int id;
//     private string name;
//     private string email;

//     public Author(string name, string email)
//     {
//         this.id = nextId++;
//         this.name = name;
//         this.email = email;
//     }
//     public string GetName()
//     {
//         return name;
//     }

//     public string GetEmail()
//     {
//         return email;
//     }
//     public override string ToString()
//     {
//         return $"Author ID: {id}, Name: {name}, Email: {email}";
//     }
// }

// public class Book
// {
//     private string title;
//     private Author[] authors;
//     private string isbn;
//     private double price;

//     public Book(string title, Author[] authors)
//     {
//         this.title = title;
//         this.authors = authors;
//         this.isbn = "N/A";
//         this.price = 0.0;
//     }

//     public Book(string title, Author[] authors, string isbn, double price)
//     {
//         this.title = title;
//         this.authors = authors;
//         this.isbn = isbn;
//         this.price = price;
//     }

//     public override string ToString()
//     {
//         string authorNames = string.Join(", ", authors.Select(a => a.ToString()));
//         return $"Title: {title}, Authors: {authorNames}, ISBN: {isbn}, Price: {price:C}";
//     }

//     public void UpdatePrice(double newPrice)
//     {
//         this.price = newPrice;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Author first = new Author("Braulio Bessa", "braulio.bessa@gmail.com");
//         Author second = new Author("Geovani Martins", "geovani.martins@gmail.com");

//         Book[] books = new Book[]
//         {
//             new Book("Poesia que Transforma", new Author[] { first }, "05810", 29.90),
//             new Book("O Sol na Cabeça", new Author[] { second }, "30914", 34.90),
//             new Book("Torto Arado", new Author[] { new Author("Itamar Vieira Junior", "itamar.vieira@gmail.com") }, "20798", 49.90)
//         };

//         foreach (Book book in books)
//         {
//             Console.WriteLine(book);
//         }

//         try
//         {
//             books[1].UpdatePrice(39.90);
//             Console.WriteLine("Updated price for book: " + books[1]);
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }
