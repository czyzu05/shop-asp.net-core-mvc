using Shop.DAL;
using Shop.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        public ActionResult Index()
        {
            var bookTypes = db.BookTypes.ToList();
            var newArrivals = db.Books.Where(book => !book.isHidden).OrderByDescending(book => book.DateAdded).Take(3).ToList();
            var bestsellers = db.Books.Where(book => !book.isHidden && book.isBestseller).Take(3).ToList();

            var vm = new HomeViewModel()
            {
                Bestsellers = bestsellers,
                BookTypes = bookTypes,
                NewArrivals = newArrivals
            };

            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}