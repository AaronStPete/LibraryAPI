using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPI.ViewModels
{
    public class BookSearchParams
    {
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Condition { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? ReturnBy { get; set; }
        public string AuthorName { get; set; }
        public string Genre { get; set; }
    }
}