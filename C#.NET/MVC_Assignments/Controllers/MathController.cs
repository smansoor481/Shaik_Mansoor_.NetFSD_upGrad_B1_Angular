using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int a, int b)
        {
            int result = a + b;
            return Content($"Addition is: {result}");
        }

        public IActionResult Multiply(int a, int b)
        {
            int result = a * b;
            return Content($"Multiplication is: {result}");
        }

    }
}
