using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class BookType
    {
        public int BookTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}