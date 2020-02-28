using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;

namespace ChefDishes.Controllers
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

        [HttpGet("chefs")]
        public IActionResult Chefs()
        {
            List<Chef> AllChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList();
            return View(AllChefs);
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes.Include(d => d.CreatedBy).ToList();
            return View(AllDishes);
        }

        [HttpGet("chefs/new")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = dbContext.Chefs.ToList();
            return View();
        }

        [HttpPost("chefs/new")]
        public IActionResult CreateChef(Chef chef)
        {
            if (ModelState.IsValid)
            {
                if ((DateTime.Now.Year - chef.Dob.Year) < 18)
                {
                    ModelState.AddModelError("Dob", "Chef must be at least 18 years old");
                    return View("NewChef");
                }
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Chefs");
            }
            return View("NewChef");
        }

        [HttpPost("dishes/create")]
        public IActionResult CreateDish(Dish dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return View("NewDish");
        }
    }
}