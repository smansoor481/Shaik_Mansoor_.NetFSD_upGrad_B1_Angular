using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details(string Name, double salary, string department)
        {
            ViewData["name"] = Name;
            ViewData["salary"] = salary;
            ViewData["department"] = department;
            return View();
        }
    }
}
