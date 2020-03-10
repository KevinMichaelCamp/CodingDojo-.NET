using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Categories.Models;

namespace Categories.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult Products()
        {
            ViewBag.Products = dbContext.Products;
            return View();
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            ViewBag.Categories = dbContext.Categories;
            return View();
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(product);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            return RedirectToAction("Products");
        }

        [HttpPost("addcategory")]
        public IActionResult AddCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(category);
                dbContext.SaveChanges();
                return RedirectToAction("Categories");
            }
            return RedirectToAction("Categories");
        }

        [HttpGet("products/{ProductId}")]
        public IActionResult ShowProduct(int ProductId)
        {
            Product product = dbContext.Products.Include(p => p.Associations)
                .ThenInclude(a => a.Category)
                .FirstOrDefault(p => p.ProductId == ProductId);

            var otherCategories = dbContext.Categories
                .Include(c => c.Associations)
                .Where(c => c.Associations.All(a => a.ProductId != ProductId));

            ViewBag.Categories = otherCategories;
            return View(product);
        }

        [HttpGet("categories/{CategoryId}")]
        public IActionResult ShowCategory(int CategoryId)
        {
            Category category = dbContext.Categories.Include(c => c.Associations)
                .ThenInclude(a => a.Product)
                .FirstOrDefault(p => p.CategoryId == CategoryId);

            var otherProducts = dbContext.Products
                .Include(p => p.Associations)
                .Where(p => p.Associations.All(a => a.CategoryId != CategoryId));

            ViewBag.Products = otherProducts;
            return View(category);
        }

        [HttpPost("products/{isProduct}")]
        public IActionResult AddToCategory(Association newAssoc)
        {
            dbContext.Associations.Add(newAssoc);
            dbContext.SaveChanges();
            return RedirectToAction("ShowProduct", new { ProductId = newAssoc.ProductId });
        }


    }
}
