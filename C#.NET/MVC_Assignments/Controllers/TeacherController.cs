using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class TeacherController : Controller
    {
        //We can use liek this also
        public IActionResult Index()
        {
            return Content("Teacher Index");
        }

        public string Details()
        {
            return "Teacher Details";
        }
    }
}
