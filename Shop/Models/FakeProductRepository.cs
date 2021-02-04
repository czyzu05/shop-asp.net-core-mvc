using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        Code = "0001",
                        Name = "Harry Potter",
                        Description = "Description Harry Potter",
                        Category = "Fantasy",
                        Price = 39.99M,
                        ImageUrl = "adres"
                    },
                    new Product
                    {
                        Code = "0002",
                        Name = "Harry",
                        Description = "Description Harry",
                        Category = "Crime",
                        Price = 59.99M,
                        ImageUrl = "adres"
                    },
                    new Product
                    {
                        Code = "0003",
                        Name = "Test",
                        Description = "Description Test",
                        Category = "Adventure",
                        Price = 69.99M,
                        ImageUrl = "adres"
                    },
                    new Product
                    {
                        Code = "0004",
                        Name = "XDDD",
                        Description = "Description XDDD",
                        Category = "Crime",
                        Price = 669.99M,
                        ImageUrl = "adres"
                    },
                };
            }
        }
    }
}
