using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int BookTypeId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public DateTime DateAdded { get; set; }
        public string FileName { get; set; }
        public string BookDescription { get; set; }
        public decimal BookPrice { get; set; }
        public bool isBestseller { get; set; }
        public bool isHidden { get; set; }

        public virtual BookType BookType { get; set; }
    }
}