using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class ViewBagDataController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mansoor";
            ViewData["age"] = 23;
            Student student = new Student()
            {
                Id = 1,
                Email = "man@gmail.com"

            };

            return View(student);
        }
    }
}
