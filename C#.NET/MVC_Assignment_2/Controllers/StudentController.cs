using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        //public string Index()
        public IActionResult Index()
        {

            //return "Welcome to Student Page";

            Student student = new Student()
            {
                Id = 1,
                Name = "Test",
                Age = 23,
                Email = "man@gmail.com"
            };

            return View(student);
        }

        public string Details()
        {
            return "Student Details Page";
        }

        public IActionResult GetStudent(int id)
        {
            return Content($"Student ID is: {id}");
        }
    }
}
