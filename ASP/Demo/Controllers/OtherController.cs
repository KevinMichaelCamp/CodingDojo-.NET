using Microsoft.AspNetCore.Mvc;
namespace Demo
{
    public class OtherController : Controller
    {
        [HttpGet("another")]
        public ViewResult Another()
        {
            return View();
        }
    }

}