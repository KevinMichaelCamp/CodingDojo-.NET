using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Models;

namespace BankAccounts.Controllers
{
    public class BankController : Controller
    {
        private Context dbContext;
        public BankController(Context context)
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
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("user/register")]
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
                return RedirectToAction("Accounts");
            }
            return View("Register");
        }

        [HttpPost("user/login")]
        public IActionResult LoginUser(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid email address");
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
                return RedirectToAction("Accounts");
            }
            return View("Login");
        }

        [HttpGet("accounts")]
        public IActionResult Accounts()
        {
            if (HttpContext.Session.GetInt32("UserID") == null)
            {
                return View("Index");
            }
            ViewBag.User = dbContext.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserID"));
            return View();
        }

        [HttpPost("accounts/transaction")]
        public IActionResult MakeTransaction(Transaction trans)
        {
            if (ModelState.IsValid)
            {
                User thisUser = dbContext.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserID"));
                trans.UserId = thisUser.UserId;
                if (trans.Type == "withdrawal")
                {
                    if (trans.Amount > thisUser.Balance)
                    {
                        Console.WriteLine(trans.Amount);
                        Console.WriteLine(thisUser.Balance);
                        Console.WriteLine("*****************HELLO***************");
                        return RedirectToAction("Accounts");
                    }
                    trans.Amount = -(trans.Amount);
                }
                dbContext.Transactions.Add(trans);
                dbContext.SaveChanges();
                return RedirectToAction("Accounts");
            }
            return RedirectToAction("Accounts");
        }
    }
}