using Microsoft.AspNetCore.Mvc;
namespace Demo     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        // Requests

        // Views Index
        [HttpGet]       //type of request
        [Route("")]     // localost:5000/
        public ViewResult Index()
        {
            return View();
        }

        // Views - Home
        [HttpGet("home")]       //type of request & route localhost:5000/home
        public ViewResult Home()
        {
            ViewBag.Example = "From the ViewBag!";
            return View();
        }

        // Redirect
        [HttpGet("redirect")]
        public RedirectToActionResult RedoIndex()
        {
            return RedirectToAction("Index");
        }

        // Redirect to Route with params
        [HttpGet("redirect/users")]
        public RedirectToActionResult RedoUsers()
        {
            // or user var param = new { name= "kevin" }
            return RedirectToAction("Users", new { name = "Kevin", age = 40 });
        }

        // Using Route Params
        [HttpGet("users/{name}/{age}")]
        public string Users(string name, int age)
        {
            return $"Hello {name}, you are {age} years old.";
        }

        // Redirect to Method in OtherController
        [HttpGet("other")]
        public RedirectToActionResult Method()
        {
            return RedirectToAction("Another", "Other");
        }

        // Return JSON Result
        [HttpGet("user1")]
        public JsonResult User1()
        {
            var response = new { first_name = "Kevin", last_name = "Camp", email = "kcamp4632@yahoo.com", age = 40 };
            return Json(response);
        }

        // IActionResult
        [HttpGet("request/{type}")]
        public IActionResult Depends(string type)
        {
            var result = new { type = "JSON" };
            if (type == "redirect")
            {
                return RedirectToAction("Index");
            }
            else if (type == "json")
            {
                return Json(result);
            }
            return View();

        }

        // POST Request
        [HttpPost("submission")] // POST to localhost:5000/submission
        public string FormSubmission(string formInput)
        {
            return formInput;
        }

    }
}
