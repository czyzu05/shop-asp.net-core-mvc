using Shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ShopContext _shopContext;

        public EFProductRepository(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<Product> Products => _shopContext.Products;
    }
}
