using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        [MaxLength(6)]
        public string Code { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [MaxLength(25)]
        public string Category { get; set; }
        [Range(5, 1000)]
        public decimal Price { get; set; }
        [MaxLength(500)]
        public string ImageUrl { get; set; }
    }
}
