using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBooks.ViewModels
{
    public class BookDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [Display(Name = "#")]
        public int NumberOfPages { get; set; }
        public string ImageUrl { get; set; }

    }
}
