using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using League.Models;
using League.Factories;

namespace League.Controllers
{
    public class LeagueController : Controller
    {
        private readonly NinjaFactory _ninjafactory;
        private readonly DojoFactory _dojofactory;
        public LeagueController(DojoFactory dfactory, NinjaFactory nfactory)
        {
            _dojofactory = dfactory;
            _ninjafactory = nfactory;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("dojos")]
        public IActionResult Dojos()
        {
            ViewBag.Dojos = _dojofactory.FindAll();
            return View();
        }

        [HttpGet("ninjas")]
        public IActionResult Ninjas()
        {
            ViewBag.Ninjas = _ninjafactory.NinjasWithDojos();
            return View();
        }

        [HttpGet("ninjas/{id}")]
        public IActionResult ShowNinja(int id)
        {
            ViewBag.Ninja = _ninjafactory.FindByID(id);
            return View();
        }

        [HttpGet("dojos/{id}")]
        public IActionResult ShowDojo(int id)
        {
            ViewBag.Dojo = _dojofactory.FindByID(id);
            return View();
        }

        [HttpPost("AddDojo")]
        public IActionResult AddDojo(Dojo dojo)
        {
            if (ModelState.IsValid)
            {
                _dojofactory.Add(dojo);
                return RedirectToAction("Dojos");
            }
            return View("Dojos");
        }

        [HttpPost("AddNinja")]
        public IActionResult AddNinja(Ninja ninja)
        {
            if (ModelState.IsValid)
            {
                _ninjafactory.Add(ninja);
                return RedirectToAction("Ninjas");
            }
            return View("Ninjas");
        }




    }
}