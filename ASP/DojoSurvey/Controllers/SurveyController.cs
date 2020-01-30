using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey
{
    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string name, string loc, string lang, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = loc;
            ViewBag.Language = lang;
            ViewBag.Comment = comment;
            return View();
        }
    }
}