using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApp.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        public TodoRepository TodoRepository { get; set; }

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }
        [Route("")]
        [Route("list")]
        // GET: /<controller>/
        public IActionResult List()
        {
            TodoRepository.AddTodo();
            Console.WriteLine(TodoRepository.GetListCount());
            return View();
        }
    }
}
