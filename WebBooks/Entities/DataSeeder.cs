using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooks.Models;

namespace WebBooks.Entities
{
    public class DataSeeder
    {
        public async static Task SeedBooks(BooksVMContext context)
        {
            if (!context.Books.Any())
            {
                LibraryData libraryData = new LibraryData();
                context.AddRange(libraryData.GetAllBooks());
                await context.SaveChangesAsync();
            }
        }
    }
}
