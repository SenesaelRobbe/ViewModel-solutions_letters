using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebBooks.Entities;
using WebBooks.Models;
using WebBooks.ViewModels;

namespace WebBooks.Controllers
{
    public class BookController : Controller
    {
        BooksVMContext db;

        public BookController(BooksVMContext context)
        {
            db = context;
        }

        // GET: /Book/
        public IActionResult Index()
        {
            BookListInfo bookListInfo = new BookListInfo
            {
                Books = db.Books
                .Select(b => new BookBasic
                {
                    Id = b.Id,
                    Title = b.Title
                })
                .ToList(),
                NumberOfBooks = db.Books.Count()
            };
            return View(bookListInfo);
        }

        // GET: /Book/Details/1
        public IActionResult Details(int id)
        {
            var bookDetail = db.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Select(b => new BookDetail
                {
                    Id = b.Id,
                    Title = b.Title,
                    ISBN = b.ISBN,
                    Author = $"{b.Author.FirstName} {b.Author.LastName}",
                    Publisher = $"{b.Publisher.Name} ({b.Publisher.Country})",
                    NumberOfPages = b.NumberOfPages,
                    ImageUrl = b.ImageUrl
                })
                .FirstOrDefault(b => b.Id == id);
                
                
            return View(bookDetail);
        }

        public IActionResult Statistics(string inputString)
        {
            var bookStatistics = new BookStatistics
            {
                
                Input = inputString,
                TotalNumberOfBooks = db.Books.Count(),
                NumberOfBooksStartingWith =
                    db.Books.Where(b => b.Title.StartsWith(inputString)).Count(),
                NumberOfBooksContaining =
                    db.Books.Where(b => b.Title.Contains(inputString)).Count(),
                NumberOfAuthorsContaining = 
                    db.Authors.Where(a => a.FirstName.Contains(inputString) || a.LastName.Contains(inputString)).Count(),
                NumberOfPublishersContaining = db.Publishers.Where(p => p.Name.Contains(inputString)).Count(),
            };

            return View(bookStatistics);
        }
    }
}