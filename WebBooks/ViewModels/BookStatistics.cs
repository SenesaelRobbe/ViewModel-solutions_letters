using System.ComponentModel.DataAnnotations;

namespace WebBooks.ViewModels
{
    public class BookStatistics
    {
        [Display(Name = "Searched for")]
        public string Input { get; set; }
        [Display(Name = "Total number of books")]
        public int TotalNumberOfBooks { get; set; }
        [Display(Name = "Books starting with")]
        public int NumberOfBooksStartingWith { get; set; }
        [Display(Name = "Books containing")]
        public int NumberOfBooksContaining { get; set; }
        [Display(Name = "Authors containing")]
        public int NumberOfAuthorsContaining { get; set; }
        [Display(Name = "Publishers containing")]
        public int NumberOfPublishersContaining { get; set; }
        
    }
}
