using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class StuController : Controller
    {
        public IActionResult controller()
        {
            List<string> students = new List<string>()
            {
                "Mansoor",
                "Rahul",
                "Ayesha",
                "John"
            };

            ViewData["students"] = students;
            return View();
        }
    }
}
