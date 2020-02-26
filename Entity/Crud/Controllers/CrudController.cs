using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Crud.Models;

namespace Crud.Controllers
{
    public class CrudController : Controller
    {
        // DB Connect
        private MyContext dbContext;
        public CrudController(MyContext context)
        {
            dbContext = context;
        }

        // Routes
        [HttpGet("")]
        public IActionResult Index()
        {
            IEnumerable<Dish> AllDishes = dbContext.Dishes.OrderByDescending(d => d.UpdatedAt);
            return View(AllDishes);
        }

        [HttpGet("show/{dishId}")]
        public IActionResult Show(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(ThisDish);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dish dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("New");
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(ThisDish);
        }

        [HttpPost("update/{dishId}")]
        public IActionResult Update(Dish updateDish, int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            ThisDish.Name = updateDish.Name;
            ThisDish.Chef = updateDish.Chef;
            ThisDish.Tastiness = updateDish.Tastiness;
            ThisDish.Calories = updateDish.Calories;
            ThisDish.Description = updateDish.Description;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dbContext.Dishes.Remove(ThisDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}