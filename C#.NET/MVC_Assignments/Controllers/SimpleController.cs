using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class SimpleController : Controller
    {
        public string Index()
        {
            return "Welcome to ASP.NET Core MVC";
        }

        public string About()
        {
            return "This is About Page";
        }
        public string Contact()
        {
            return "Contact us at support@test.com";
        }
        public IActionResult Index1()
        {
            return Content("Welcome to ASP.NET Core MVC");
        }
    }
}
