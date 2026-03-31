using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Student Index";
        }

        public string Profile()
        {
            return "Student Profile";
        }
    }
}
