﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryAPI.Models
{
    public class Book 
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }
        public string Condition { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? ReturnBy { get; set; }

        //Foreign Keys:
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }

    }
}