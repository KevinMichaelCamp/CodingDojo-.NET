using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Demo.Models;
using Demo.Factories;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserFactory _userFactory;
        public HomeController(UserFactory uFactory)
        {
            _userFactory = uFactory;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            ViewBag.Users = _userFactory.FindAll();
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userFactory.Add(user);
                return RedirectToAction("Users");
            }
            return View("Index");
        }

        [HttpGet("users/{id}")]
        public IActionResult Show(int id)
        {
            ViewBag.User = _userFactory.FindByID(id);
            return View();
        }

    }
}