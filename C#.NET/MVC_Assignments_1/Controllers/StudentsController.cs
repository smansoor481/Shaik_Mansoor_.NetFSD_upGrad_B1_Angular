using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Details(string name, int age)
        { 
            ViewData["name"] = name;
            ViewData["age"] = age;
            return View();
        }
    }
}
