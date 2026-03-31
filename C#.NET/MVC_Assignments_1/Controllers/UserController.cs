using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Details(string name, int age)
        {
            return Content($"Name: {name}, Age: {age}");
        }
    }
}
