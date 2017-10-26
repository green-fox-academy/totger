using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetApplication.Controllers.Home
{
    public class HomeController : Controller
    {
        Form form;

        public HomeController(Form form)
        {
            this.form = form; 
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(Form form)
        {
            return RedirectToAction("Greet", form);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(Form form)
        {
            return View(form);
        }
    }
}
