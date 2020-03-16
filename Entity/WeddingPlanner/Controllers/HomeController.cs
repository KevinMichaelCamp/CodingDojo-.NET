using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        private User loggedInUser
        {
            get { return dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserID")); }
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserID", user.UserId);
                return RedirectToAction("DashBoard");
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid email");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (loggedInUser == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.ThisUser = loggedInUser;
            var weddings = dbContext.Weddings
                .Include(w => w.Responses)
                .OrderByDescending(w => w.Date);

            return View(weddings.ToList());
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            if (loggedInUser == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Wedding wedding)
        {
            if (ModelState.IsValid)
            {

                wedding.UserId = loggedInUser.UserId;
                dbContext.Weddings.Add(wedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");

            }
            return RedirectToAction("Dashboard");
        }

        [HttpGet("remove/{weddingId}")]
        public IActionResult Remove(int weddingId)
        {
            if (loggedInUser == null)
            {
                return RedirectToAction("Index");
            }
            Wedding toDelete = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId && w.UserId == loggedInUser.UserId);
            if (toDelete == null)
            {
                return RedirectToAction("Dashbaord");
            }
            dbContext.Weddings.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("RSVP/{weddingId}")]
        public IActionResult RSVP(int weddingId)
        {
            if (loggedInUser == null)
            {
                return RedirectToAction("Index");
            }
            if (!dbContext.Weddings.Any(w => w.WeddingId == weddingId))
            {
                return RedirectToAction("Dashboard");
            }
            Response newResponse = new Response()
            {
                WeddingId = weddingId,
                UserId = loggedInUser.UserId
            };
            dbContext.Responses.Add(newResponse);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("unRSVP/{weddingId}")]
        public IActionResult unRSVP(int weddingId)
        {
            if (loggedInUser == null)
            {
                return RedirectToAction("Index");
            }
            if (!dbContext.Weddings.Any(w => w.WeddingId == weddingId))
            {
                return RedirectToAction("Dashboard");
            }
            Response rsvp = dbContext.Responses.FirstOrDefault(r => r.UserId == loggedInUser.UserId && r.WeddingId == weddingId);
            dbContext.Responses.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("show/{weddingId}")]
        public IActionResult Show(int weddingId)
        {
            Wedding thisWedding = dbContext.Weddings
                .Include(w => w.Responses)
                .ThenInclude(r => r.Guest)
                .FirstOrDefault(w => w.WeddingId == weddingId);
            return View(thisWedding);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}

