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
                var query = db.Books.Include("Author").Include("Genre");

                if (!String.IsNullOrEmpty(param.Title))
                {
                    query = query.Where(w => w.Title == param.Title);
                }

                return query.ToList();
            }
            // get all books from the database
        }

        //search by title


        //search by author


        //search by genre


    }
}

