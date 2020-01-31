using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SurveyValidation.Models;

namespace SurveyValidation.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("validate")]
        public IActionResult Validate(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Result", user);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("result")]
        public IActionResult Result(User user)
        {
            return View(user);
        }
    }
}