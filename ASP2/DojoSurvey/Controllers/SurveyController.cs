using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(User user)
        {
            return View(user);
        }
    }
}