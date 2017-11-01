using Microsoft.AspNetCore.Mvc;
using SqliteTest.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SqliteTest.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        TestDataRepository TestDataRepository;

        public HomeController(TestDataRepository testDataRepository)
        {
            TestDataRepository = testDataRepository;
        }

        [Route("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(TestDataRepository.ReturnCount());
        }

        [Route("add")]
        public IActionResult AddData()
        {
            TestDataRepository.AddData();
            return RedirectToAction("Index");
        }
    }
}
