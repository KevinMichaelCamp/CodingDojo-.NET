using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Controllers
{
    public class DemoController : Controller
    {
        private MyContext dbContext;
        public DemoController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            ViewBag.AllUsers = AllUsers;
            return View();
        }

        [HttpGet("add")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddUser");
        }

        [HttpGet("edit/{userId}")]
        public IActionResult EditUser(int userId)
        {

            ViewBag.User = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
            return View();
        }

        [HttpPost("update/{userId}")]
        public IActionResult UpdateUser(User updatedUser, int userId)
        {
            if (ModelState.IsValid)
            {
                User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
                RetrievedUser.FirstName = updatedUser.FirstName;
                RetrievedUser.LastName = updatedUser.LastName;
                RetrievedUser.Email = updatedUser.Email;
                RetrievedUser.Password = updatedUser.Password;
                RetrievedUser.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("EditUser");
        }

        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
            dbContext.Users.Remove(RetrievedUser);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}