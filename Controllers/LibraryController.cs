using Microsoft.AspNetCore.Mvc;
using Library_Management_System.Models;
using System.Linq;

namespace Library_Management_System.Controllers
{
    public class LibraryController : Controller
    {
        private static Library library;

        static LibraryController()
        {
            library = new Library
            {
                Id = 1,
                Name = "Lyceum Library",
                Location = "Km.30 Tunasan Muntinlupa City",
                Books = new System.Collections.Generic.List<Book>(),
                Users = new System.Collections.Generic.List<User>()
            };

            SeedData();
        }

        private static void SeedData()
        {
            // Authors
            var author1 = new Author { Id = 1, Name = "J.K. Rowling", Biography = "British author" };
            var author2 = new Author { Id = 2, Name = "George Orwell", Biography = "English novelist" };
            var author3 = new Author { Id = 3, Name = "Agatha Christie", Biography = "English writer of detective fiction" };
            var author4 = new Author { Id = 4, Name = "Stephen King", Biography = "American author of horror novels" };
            var author5 = new Author { Id = 5, Name = "Jane Austen", Biography = "English novelist known for romantic fiction" };
            var author6 = new Author { Id = 6, Name = "Mark Twain", Biography = "American writer and humorist" };
            var author7 = new Author { Id = 7, Name = "Ernest Hemingway", Biography = "American novelist and short story writer" };
            var author8 = new Author { Id = 8, Name = "F. Scott Fitzgerald", Biography = "American novelist of the Jazz Age" };
            var author9 = new Author { Id = 9, Name = "J.R.R. Tolkien", Biography = "British author of high fantasy" };
            var author10 = new Author { Id = 10, Name = "Harper Lee", Biography = "American novelist best known for To Kill a Mockingbird" };

            // Users
            var user1 = new User { Id = 1, FullName = "Alice Smith", Email = "alice@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-3), BorrowedBooks = new List<Book>() };
            var user2 = new User { Id = 2, FullName = "Bob Johnson", Email = "bob@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-2), BorrowedBooks = new List<Book>() };
            var user3 = new User { Id = 3, FullName = "Carol White", Email = "carol@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-1), BorrowedBooks = new List<Book>() };
            var user4 = new User { Id = 4, FullName = "David Brown", Email = "david@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-5), BorrowedBooks = new List<Book>() };
            var user5 = new User { Id = 5, FullName = "Eve Davis", Email = "eve@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-4), BorrowedBooks = new List<Book>() };
            var user6 = new User { Id = 6, FullName = "Frank Moore", Email = "frank@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-6), BorrowedBooks = new List<Book>() };
            var user7 = new User { Id = 7, FullName = "Grace Wilson", Email = "grace@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-7), BorrowedBooks = new List<Book>() };
            var user8 = new User { Id = 8, FullName = "Henry Taylor", Email = "henry@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-8), BorrowedBooks = new List<Book>() };
            var user9 = new User { Id = 9, FullName = "Ivy Anderson", Email = "ivy@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-9), BorrowedBooks = new List<Book>() };
            var user10 = new User { Id = 10, FullName = "Jack Thomas", Email = "jack@example.com", Role = "Member", Date_Registered = DateTime.Now.AddMonths(-10), BorrowedBooks = new List<Book>() };

            library.Users.Add(user1);
            library.Users.Add(user2);
            library.Users.Add(user3);
            library.Users.Add(user4);
            library.Users.Add(user5);
            library.Users.Add(user6);
            library.Users.Add(user7);
            library.Users.Add(user8);
            library.Users.Add(user9);
            library.Users.Add(user10);

            // Books
            var book1 = new Book
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                ISBN = "9780439554930",
                PublicationYear = 1997,
                DateLastReturned = DateTime.Now.AddDays(-7),
                IsAvailable = true,
                Author = author1,
                Genre = BookGenre.Fantasy
            };

            var book2 = new Book
            {
                Title = "1984",
                ISBN = "9780451524935",
                PublicationYear = 1949,
                DateLastReturned = DateTime.Now.AddDays(-4),
                IsAvailable = true,
                Author = author2,
                Genre = BookGenre.ScienceFiction
            };

            var book3 = new Book
            {
                Title = "Murder on the Orient Express",
                ISBN = "9780062073501",
                PublicationYear = 1934,
                DateLastReturned = DateTime.Now.AddDays(-10),
                IsAvailable = true,
                Author = author3,
                Genre = BookGenre.Mystery
            };

            var book4 = new Book
            {
                Title = "The Shining",
                ISBN = "9780385121675",
                PublicationYear = 1977,
                DateLastReturned = DateTime.Now.AddDays(-2),
                IsAvailable = true,
                Author = author4,
                Genre = BookGenre.Thriller
            };

            var book5 = new Book
            {
                Title = "Pride and Prejudice",
                ISBN = "9780141040349",
                PublicationYear = 1813,
                DateLastReturned = DateTime.Now.AddDays(-15),
                IsAvailable = true,
                Author = author5,
                Genre = BookGenre.Romance
            };

            var book6 = new Book
            {
                Title = "The Adventures of Tom Sawyer",
                ISBN = "9780143039563",
                PublicationYear = 1876,
                DateLastReturned = DateTime.Now.AddDays(-12),
                IsAvailable = true,
                Author = author6,
                Genre = BookGenre.Adventure
            };

            var book7 = new Book
            {
                Title = "The Old Man and the Sea",
                ISBN = "9780684801223",
                PublicationYear = 1952,
                DateLastReturned = DateTime.Now.AddDays(-3),
                IsAvailable = true,
                Author = author7,
                Genre = BookGenre.Drama
            };

            var book8 = new Book
            {
                Title = "The Great Gatsby",
                ISBN = "9780743273565",
                PublicationYear = 1925,
                DateLastReturned = DateTime.Now.AddDays(-6),
                IsAvailable = true,
                Author = author8,
                Genre = BookGenre.Classic
            };

            var book9 = new Book
            {
                Title = "The Hobbit",
                ISBN = "9780547928227",
                PublicationYear = 1937,
                DateLastReturned = DateTime.Now.AddDays(-9),
                IsAvailable = true,
                Author = author9,
                Genre = BookGenre.Fantasy
            };

            var book10 = new Book
            {
                Title = "To Kill a Mockingbird",
                ISBN = "9780061120084",
                PublicationYear = 1960,
                DateLastReturned = DateTime.Now.AddDays(-11),
                IsAvailable = true,
                Author = author10,
                Genre = BookGenre.Historical
            };

            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            library.Books.Add(book4);
            library.Books.Add(book5);
            library.Books.Add(book6);
            library.Books.Add(book7);
            library.Books.Add(book8);
            library.Books.Add(book9);
            library.Books.Add(book10);

            user1.BorrowedBooks.Add(book1);
            book1.IsAvailable = false;

            user1.BorrowedBooks.Add(book2);
            book1.IsAvailable = false;

            user2.BorrowedBooks.Add(book3);
            book1.IsAvailable = false;
        }


        // Show list of all books
        public IActionResult Books()
        {
            return View(library.Books);
        }

  
        public IActionResult UserDetails(int id)
        {
            var user = library.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            return View(user);
        }

     
        [HttpPost]
        public IActionResult BorrowBook(int userId, string isbn)
        {
            var user = library.Users.FirstOrDefault(u => u.Id == userId);
            var book = library.Books.FirstOrDefault(b => b.ISBN == isbn);

            if (user == null || book == null || !book.IsAvailable)
            {
                return BadRequest("Invalid user or book, or book unavailable.");
            }

            book.IsAvailable = false;
            book.DateLastReturned = System.DateTime.MinValue;
            user.BorrowedBooks.Add(book);

            return RedirectToAction("UserDetails", new { id = userId });
        }

        // Return a book
        [HttpPost]
        public IActionResult ReturnBook(int userId, string isbn)
        {
            var user = library.Users.FirstOrDefault(u => u.Id == userId);
            var book = user?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (user == null || book == null)
            {
                return BadRequest("User or book not found.");
            }

            book.IsAvailable = true;
            book.DateLastReturned = System.DateTime.Now;
            user.BorrowedBooks.Remove(book);

            return RedirectToAction("UserDetails", new { id = userId });
        }

        // You can add more actions like AddBook, etc.
    }
}
