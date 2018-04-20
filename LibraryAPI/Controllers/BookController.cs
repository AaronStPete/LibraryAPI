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
    [Route("api/books")]
    public class BookController : ApiController
    {
        public IEnumerable<Book> GetAll()
        {
            // get all books from the database
            var db = new LibraryContext();
            return db.Books;
        }

        //search by title
        //GET api/books/title
        //http://localhost:56372/api/books?title=The_Big_Test
        [Route("title/{title}")]
        public IEnumerable<Book> GetByTitle(string title)
        {
            var db = new LibraryContext();
            title = title.Replace('_', ' ');
            return db.Books.Where(w => w.Title.Contains(title));
        }

        //search by author
        //GET api/books/author
        //http://localhost:56372/api/books?author=A'abohrn
        [Route("author/{author}")]
        public IEnumerable<Book> GetByAuthor(string author)
        {
            var db = new LibraryContext();
            var query = db.Books.Include(i => i.Author);
            author = author.Replace('_', ' ');
            return query.Where(w => w.Author.Name == author);
        }

        //search by genre
        //GET api/books/genre

        [Route("genre{genre}")]
        public IEnumerable<Book> GetByGenre(string genre)
        {
            var db = new LibraryContext();
            var query = db.Books.Include(i => i.Genre);
            genre = genre.Replace('_', ' ');
            return query.Where(w => w.Genre.Name == genre);
        }

    }
}

