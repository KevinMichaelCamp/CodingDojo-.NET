using Microsoft.AspNetCore.Mvc;
namespace Demo     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        // Requests

        [HttpGet]       //type of request
        [Route("")]     // localost:5000/
        public string Index()
        {
            return "Hello from HelloController!";
        }


        [HttpGet("hello")]       //type of request & route localhost:5000/hello

        public string Hello()
        {
            return "Hi again!";
        }

        [HttpGet("users/{username}/{location}/{age}")]   // localhost:5000/users/???
        public string HelloUser(string username, string location, int age)
        {
            return $"Hello {username} from {location}! You are {age} years old.";
        }

        [HttpPost("submission")] // POST to localhost:5000/submission
        public string FormSubmission(string formInput)
        {
            return formInput;
        }

    }
}
