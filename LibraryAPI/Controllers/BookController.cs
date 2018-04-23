using LibraryAPI.Context;
using LibraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using LibraryAPI.ViewModels;

namespace LibraryAPI.Controllers
{
    public class BookController : ApiController
    {
        [HttpGet]
        public IEnumerable<Book> Search([FromUri]BookSearchParams param)
        {
            using (var db = new LibraryContext())
            {
                var query = db.Books.Include(i => i.Author).Include(i => i.Genre);

                if (!String.IsNullOrEmpty(param.Title))
                {
                    //search by title
                    query = query.Where(w => w.Title == param.Title);
                }
                if (!String.IsNullOrEmpty(param.Author))
                {
                    //search by author
                    query = query.Where(w => w.Author.Name == param.Author);
                }
                if (!String.IsNullOrEmpty(param.Genre))
                {
                    //search by genre
                    query = query.Where(w => w.Genre.Name == param.Genre);
                }
                return query.ToList();
            }
        }

        // get all books from the database
        





    }
}

