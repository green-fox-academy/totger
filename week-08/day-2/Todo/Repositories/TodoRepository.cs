using System;
using System.Linq;
using TodoApp.Entities;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public int GetListCount()
        {
            return TodoContext.Todos.Count();
        }

        public void AddTodo()
        {
            TodoContext.Todos.Add(new Models.Todo() { Title = "dsfsg"});
            TodoContext.SaveChanges();
        }
    }
}
