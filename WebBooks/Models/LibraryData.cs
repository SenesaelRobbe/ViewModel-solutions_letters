using System;
using System.Collections.Generic;
using System.Linq;

namespace WebBooks.Models
{
    public class LibraryData
    {
        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Book> Books { get; set; }


        public LibraryData()
        {
            Authors = new List<Author> {
                new Author {
                    //Id = 1,
                    FirstName = "James",
                    LastName = "Sharp",
                    BirthDate = new DateTime(1980, 5, 20) },
                new Author {
                    //Id = 2,
                    FirstName = "Sophie",
                    LastName = "Netty",
                    BirthDate = new DateTime(1992, 3, 4) },
                new Author {
                    //Id = 3,
                    FirstName = "Elisa",
                    LastName = "Yammy",
                    BirthDate = new DateTime(1996, 8, 12) },
            };

            Publishers = new List<Publisher>
            {
                new Publisher {
                    //Id = 1,
                    Name ="IT-publishers", Country="UK" },
                new Publisher {
                    //Id = 2,
                    Name ="FoodBooks", Country="Sweden" },
            };
            Books = new List<Book>
            {
                new Book {
                    //Id = 1,
                            ISBN ="123456789",
                            Title ="Learning C#" ,
                            NumberOfPages = 420,
                            ImageUrl = "images/book1.jpg",
                            Author = Authors[0],
                            Publisher = Publishers[0] },
                new Book {
                    //Id = 2,
                            ISBN ="45689132",
                            Title ="Mastering Linq" ,
                            NumberOfPages = 360,
                            ImageUrl = "images/book2.jpg",
                            Author = Authors[1],
                            Publisher = Publishers[0] },
                new Book {
                    //Id = 3,
                            ISBN ="15856135",
                            Title ="Mastering Xamarin" ,
                            NumberOfPages = 360,
                            ImageUrl = "images/book2.jpg",
                            Author = Authors[0],
                            Publisher = Publishers[0] },
                new Book {
                    //Id = 4,
                            ISBN ="56789564",
                            Title ="Exploring ASP.Net Core 2.0" ,
                            NumberOfPages = 360,
                            ImageUrl = "images/book3.jpg",
                            Author = Authors[1],
                            Publisher = Publishers[0] },
                new Book {
                    //Id = 5,
                            ISBN ="234546684",
                            Title ="Unity Game Development" ,
                            NumberOfPages = 420,
                            ImageUrl = "images/book1.jpg",
                            Author = Authors[1],
                            Publisher = Publishers[0] },
                new Book {
                    //Id = 6,
                            ISBN ="789456258",
                            Title ="Cooking is fun" ,
                            NumberOfPages = 40,
                            ImageUrl = "images/book3.jpg",
                            Author = Authors[2],
                            Publisher = Publishers[1] },
                new Book {
                    //Id = 7,
                            ISBN ="94521546",
                            Title ="Secret recipes" ,
                            NumberOfPages = 53,
                            ImageUrl = "images/book3.jpg",
                            Author = Authors[2],
                            Publisher = Publishers[1] },
            };
        }

        public Book GetBookById(int id)
        {
            return Books.FirstOrDefault(b => b.Id == id);
        }
        public List<Book> GetAllBooks()
        {
            return Books.OrderBy(b => b.Title).ToList();
        }
    }
}
