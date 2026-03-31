using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_3.Models;
using MVC_Assignment_3.ViewModel;

namespace MVC_Assignment_3.Controllers
{
    public class UserController : Controller
    {
        //public static List<User> users = new List<User>()
        //{
        //    new User() { Id = 1, Name = "Mansoor" }
        //};
        static List<User> users = new List<User>();


        //register get
        public IActionResult Register()
        {

            return View();
        }

        //reggister post
        [HttpPost]
        public IActionResult Register(User user)
        {
            //Automaticaly it can be validated no hardcoded
            if(ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }

        //login get
        public IActionResult Login()
        {
            return View();
        }

        //login post
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if(user !=null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email!);
                return RedirectToAction("Profile");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");
            if(email == null)
            {
                return RedirectToAction("Login");
            }

            var user = users.FirstOrDefault(u => u.Email ==  email);

            var vm = new UserViewModel
            {
                Id = user!.Id,
                Name = user.Name,
                Email = user.Email
            };


            return View(vm);
        }

        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
            {
                return RedirectToAction("Login");
            }

            var user = users.FirstOrDefault(u => u.Email == email);
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Email == updatedUser.Email);

            if (user != null)
            {
                user.Name = updatedUser.Name;
                user.Email = updatedUser.Email;
            }
            return RedirectToAction("Profile");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
