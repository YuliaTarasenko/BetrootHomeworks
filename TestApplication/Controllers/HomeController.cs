using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestApplication.Models;
using TestApplication.Logic;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;
        public HomeController(MyContext context) => _context = context;


        public IActionResult Index() => View();

        public IActionResult AddUser() => View();

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            var newId = _context.Users.Count() + 1;
            _context.Users.Add(user with { Id = newId});
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}