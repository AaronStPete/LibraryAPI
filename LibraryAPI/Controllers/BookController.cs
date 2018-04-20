using LibraryAPI.Context;
using LibraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace LibraryAPI.Controllers
{
    public class BookController : ApiController
    {
        public IEnumerable<Book> GetAll()
        {
            // get all books from the database
            var db = new LibraryContext();
            return db.Books;
        }

        //search by title
        

        //search by author
        

        //search by genre
        

    }
}

