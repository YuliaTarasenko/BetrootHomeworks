using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MVC.Models;
using System;
using Microsoft.EntityFrameworkCore;
using MVC.Logic;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;
        public HomeController(MyContext context) => _context = context;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddUser() => View();
        public IActionResult AddOrder() => View();
        public IActionResult UsersList() => View();
        public IActionResult OrdersList() => View();

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            var newId = _context.Users.Count() + 1;
            _context.Users.Add(user with { Id = newId});
            _context.SaveChanges();
            return RedirectToAction("UsersList");
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            var newId = _context.Orders.Count() + 1;
            _context.Orders.Add(order with { Id = newId });
            _context.SaveChanges();
            return RedirectToAction("OrdersList");
        }

        public IActionResult Api() => View();

        public IActionResult Orders()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}