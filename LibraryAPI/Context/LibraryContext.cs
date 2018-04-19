using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryAPI.Context
{
    public class LibraryContext :DbContext
    {
        public LibraryContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Models.Book> Books { get; set; }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
        public DbSet<Models.CheckoutLedger> CheckoutLedgers { get; set; }
    }
}