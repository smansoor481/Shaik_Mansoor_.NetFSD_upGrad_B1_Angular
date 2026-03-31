using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class StudentManagmentController : Controller
    {
        // Temporary data (acts like DB)
        static List<Student> students = new List<Student>();

        // READ (Index Page)
        public IActionResult Index()
        {
            return View(students);
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return RedirectToAction("Index");
        }

        // UPDATE (GET)
        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        // UPDATE (POST)
        [HttpPost]
        public IActionResult Edit(Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == updatedStudent.Id);

            if (student != null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
                student.Email = updatedStudent.Email;
            }

            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }

            return RedirectToAction("Index");
        }
    }
}