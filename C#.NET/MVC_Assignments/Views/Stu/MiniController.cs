using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Views.Stu
{
    public class MiniController : Controller
    {
        public IActionResult Details(string name, int age)
        {
            ViewData["name"] = name;
            ViewData["age"] = age;

            ViewData["message"] = "Student Details";
            return View();
        }
    }
}
