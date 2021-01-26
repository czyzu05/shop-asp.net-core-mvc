using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> Bestsellers { get; set; }
        public IEnumerable<Book> NewArrivals { get; set; }
        public IEnumerable<BookType> BookTypes { get; set; }
    }
}