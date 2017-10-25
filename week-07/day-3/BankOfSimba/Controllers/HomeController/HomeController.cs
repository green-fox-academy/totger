using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers.HomeController
{
    public class HomeController : Controller
    {
        [Route ("simba")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View (new BankAccount("Simba", 2000, BankAccount.Animal.Lion, true));
        }

        [Route ("list")]
        public IActionResult AnimalList()
        {
            var animalList = new List<BankAccount> {
                new BankAccount("Tomi", 3242, BankAccount.Animal.Monkey, false),
                new BankAccount("Mufasa", 23123, BankAccount.Animal.Lion, true, true),
                new BankAccount("Bela", 1121, BankAccount.Animal.Vulture, false),
                new BankAccount("Scar", 2222, BankAccount.Animal.Hyena, true) };
            return View(animalList);
        }
    }
}
