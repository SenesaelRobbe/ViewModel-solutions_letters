using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBooks.ViewModels
{
    public class BookListInfo
    {
        public List<BookBasic> Books { get; set; }
        [Display(Name = "Number of books")]
        public int NumberOfBooks { get; set; }
    }
}
