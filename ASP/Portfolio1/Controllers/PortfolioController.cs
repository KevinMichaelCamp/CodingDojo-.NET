using Microsoft.AspNetCore.Mvc;

namespace Portfolio1
{
    public class PortfolioController : Controller
    {
        // Requests
        [HttpGet("")]           //localhost:5000
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet("projects")]   //localhost:5000/projects
        public string Projects()
        {
            return "These are my projects - ";
        }

        [HttpGet("contacts")]   //localhost:5000/contacts
        public string Contacts()
        {
            return "This is my Contact Info -";
        }
    }
}