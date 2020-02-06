using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using LoginRegister.Models;

namespace LoginRegister.Controllers
{
    public class LoginRegisterController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("LoggedIn", user);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("register")]
        public IActionResult Register(RegUser user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Registered", user);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("loggedin")]
        public IActionResult LoggedIn(LogUser user)
        {
            return View(user);
        }

        [HttpGet("registered")]
        public IActionResult Registered(RegUser user)
        {
            return View(user);
        }

    }
}