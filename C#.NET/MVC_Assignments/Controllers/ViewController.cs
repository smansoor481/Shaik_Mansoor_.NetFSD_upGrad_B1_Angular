using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
