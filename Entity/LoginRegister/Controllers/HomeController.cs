using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LoginRegister.Models;

namespace LoginRegister.Controllers
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
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost("registeruser")]
        public IActionResult RegisterUser(User user)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Register");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserID", user.UserId);
                return RedirectToAction("Success", new { Message = "Registration" });

            }
            return View("Register");
        }

        [HttpPost("loguser")]
        public IActionResult LogUser(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid email");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserId);
                return RedirectToAction("Success", new { Message = "Login" });
            }
            return View("Login");
        }

        [HttpGet("success/{Message}")]
        public IActionResult Success(string Message)
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Message = Message;
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}