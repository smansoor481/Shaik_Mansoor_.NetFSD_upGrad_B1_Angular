using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class ShowController : Controller
    {
        public IActionResult Info()
        {
            ViewData["name"] = "John";
            ViewData["age"] = "25";
            return View();
        }

        public IActionResult Title()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }
    }
}
