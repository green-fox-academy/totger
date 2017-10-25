using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
		[Route("hello")]
		public IActionResult Hello()
		{
			return Content("Hi there!");
		}
       
    }
}
