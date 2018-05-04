using Microsoft.EntityFrameworkCore;
using WebBooks.Models;

namespace WebBooks.Entities
{
    public class BooksVMContext : DbContext
    {
        public BooksVMContext(DbContextOptions<BooksVMContext> options)
             : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Singularize table names
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<Book>().ToTable("Book");
        }
        public  DbSet<Publisher> Publishers { get; set; }
        public  DbSet<Author> Authors { get; set; }
        public  DbSet<Book> Books { get; set; }
    }
}
