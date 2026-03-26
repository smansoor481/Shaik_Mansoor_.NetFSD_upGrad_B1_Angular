using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignments.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProduct(int id)
        {
            return Content($"Product Id is: {id}");
        }
    }
}
