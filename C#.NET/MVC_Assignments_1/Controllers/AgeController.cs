using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class AgeController : Controller
    {
        public IActionResult Age(int age)
        {
            ViewData["age"] = age;
            return View();
        }
    }
}
