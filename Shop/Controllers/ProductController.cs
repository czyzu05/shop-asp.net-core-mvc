using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        public readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            List<Product> products = _productRepository.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Product prod = new Product();

            return View(prod);
        }

        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    _context.Add(product);
        //    _context.SaveChanges();

        //    return RedirectToAction("index");
        //}

        //public IActionResult Details(string Id)
        //{
        //    Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();

        //    return View(prod);
        //}

        //[HttpGet]
        //public IActionResult Edit(string Id)
        //{
        //    Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();

        //    return View(prod);
        //}

        //[HttpPost]
        //public IActionResult Edit(Product product)
        //{
        //    _context.Attach(product);
        //    _context.Entry(product).State = EntityState.Modified;
        //    _context.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult Delete(string Id)
        //{
        //    Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();

        //    return View(prod);
        //}

        //[HttpPost]
        //public IActionResult Delete(Product product)
        //{
        //    _context.Attach(product);
        //    _context.Entry(product).State = EntityState.Deleted;
        //    _context.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}
