using Shop.Migrations;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Shop.DAL
{
     public class StoreInitializer : MigrateDatabaseToLatestVersion<StoreContext, Configuration>
    {
        //protected override void Seed(StoreContext context)
        //{
        //    SeedStoreData(context);

        //    base.Seed(context);
        //}

        public static void SeedStoreData(StoreContext context)
        {
            var bookTypes = new List<BookType>
            {
                new BookType() {BookTypeId = 1, Name = "Fantasy", IconFileName = "fantasy.png"},
                new BookType() {BookTypeId = 2, Name = "Crime", IconFileName = "crime.png"},
                new BookType() {BookTypeId = 3, Name = "Adventure", IconFileName = "adventure.png"},
                new BookType() {BookTypeId = 4, Name = "Hobby", IconFileName = "hobby.png"},
                new BookType() {BookTypeId = 5, Name = "Biography", IconFileName = "biography.png"},
                new BookType() {BookTypeId = 6, Name = "Horror", IconFileName = "horror.png"},
                new BookType() {BookTypeId = 7, Name = "For Children", IconFileName = "forChildren.png"},
                new BookType() {BookTypeId = 8, Name = "Sale", IconFileName = "sale.png"},
            };

            bookTypes.ForEach(item => context.BookTypes.AddOrUpdate(item));
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book() {BookId = 1, BookAuthor = "J.K. Rowling", BookTitle = "Harry Potter and the Order of the Phoenix", BookPrice = 99, FileName = "1.png", isBestseller = true, DateAdded = new DateTime(2020, 02, 05), BookTypeId = 1 },
                new Book() {BookId = 2, BookAuthor = "George R.R. Martin", BookTitle = "The Ice Dragon", BookPrice = 59, FileName = "2.png", isBestseller = false, DateAdded = new DateTime(2020, 05, 11), BookTypeId = 1 },
                new Book() {BookId = 3, BookAuthor = "Jill Tomlinson", BookTitle = "The Owl Who Was Afraid of the Dark", BookPrice = 69, FileName = "3.png", isBestseller = false, DateAdded = new DateTime(2020, 09, 12), BookTypeId = 7 },
                new Book() {BookId = 4, BookAuthor = "Agatha Christie", BookTitle = "The Murder of Roger Ackroyd", BookPrice = 69, FileName = "4.png", isBestseller = false, DateAdded = new DateTime(2021, 01, 08), BookTypeId = 2 },
                new Book() {BookId = 5, BookAuthor = "David Jason", BookTitle = "A Del of a Life", BookPrice = 39, FileName = "5.png", isBestseller = true, DateAdded = new DateTime(2021, 01, 06), BookTypeId = 5 },
                new Book() {BookId = 6, BookAuthor = "Hugh Fearnley-Whittingstall", BookTitle = "Eat Better Forever", BookPrice = 39, FileName = "6.png", isBestseller = true, DateAdded = new DateTime(2020, 07, 07), BookTypeId = 4 },
                new Book() {BookId = 7, BookAuthor = "Call for the Dead", BookTitle = "John le Carre", BookPrice = 99, FileName = "7.png", isBestseller = false, DateAdded = new DateTime(2020, 12, 12), BookTypeId = 8 },
                new Book() {BookId = 8, BookAuthor = "Lee Child", BookTitle = "The Sentinel", BookPrice = 29, FileName = "8.png", isBestseller = true, DateAdded = new DateTime(2021, 11, 02), BookTypeId = 3 },
            };
            books.ForEach(item => context.Books.AddOrUpdate(item));
            context.SaveChanges();
        }
    }
}