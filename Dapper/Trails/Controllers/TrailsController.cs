using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Trails.Models;
using Trails.Factories;

namespace Trails.Controllers
{
    public class TrailsController : Controller
    {
        private readonly TrailFactory _trailFactory;
        public TrailsController(TrailFactory tFactory)
        {
            _trailFactory = tFactory;
        }

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("add")]
        public ViewResult Add()
        {
            return View();
        }

        [HttpGet("trails")]
        public IActionResult Trails()
        {
            ViewBag.Trails = _trailFactory.FindAll();
            return View();
        }

        [HttpGet("trails/{id}")]
        public IActionResult Show(int id)
        {
            ViewBag.Trail = _trailFactory.FindByID(id);
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Trail trail)
        {
            if (ModelState.IsValid)
            {
                _trailFactory.Add(trail);
                return RedirectToAction("Trails");
            }
            return View("Add");
        }
    }
}