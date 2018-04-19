using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryAPI.Models
{
    public class CheckoutLedger
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserEmail { get; set; }

        //Foreign Keys:
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}