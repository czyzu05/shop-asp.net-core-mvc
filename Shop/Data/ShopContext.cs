using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopContext : IdentityDbContext<IdentityUser>
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
