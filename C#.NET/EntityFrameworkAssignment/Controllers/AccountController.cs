using EntityFrameworkAssignment.Entity;
using EntityFrameworkAssignment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkAssignment.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountRepository accountRepository;

        public AccountController()
        {
            accountRepository = new AccountRepository();
        }

        // get all
        public IActionResult Index()
        {
            var accounts = accountRepository.GetAccounts();
            return View(accounts);
        }

        // get by id
        public IActionResult Details(int id)
        {
            var account = accountRepository.GetAccount(id);
            return View(account);
        }

       
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(Account account)
        {
            accountRepository.AddAccount(account);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            accountRepository.DeleteAccount(id);
            return RedirectToAction("Index");
        }

       
        public IActionResult Edit(int id)
        {
            var account = accountRepository.GetAccount(id);
            return View(account);
        }

       
        [HttpPost]
        public IActionResult Edit(Account account)
        {
            accountRepository.UpdateAccount(account);
            return RedirectToAction("Index");
        }
    }
}